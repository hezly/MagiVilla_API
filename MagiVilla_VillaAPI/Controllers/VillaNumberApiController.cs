using AutoMapper;
using Azure;
using MagiVilla_VillaAPI.Data;
using MagiVilla_VillaAPI.Logging;
using MagiVilla_VillaAPI.Models;
using MagiVilla_VillaAPI.Repositories.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace MagiVilla_VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaNumberAPI")]
    [ApiController]
    public class VillaNumberApiController : ControllerBase
    {
        //private readonly ILogging _logger;
        private readonly IVillaNumberRepository _dbVillaNumber;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;
        private readonly APIResponse _response;
        public VillaNumberApiController(IVillaNumberRepository dbVillaNumber, IMapper mapper, IVillaRepository dbVilla) 
        {
            _dbVillaNumber = dbVillaNumber;
            _mapper = mapper;
            _response = new APIResponse();
            _dbVilla = dbVilla;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<VillaNumberDTO>>> GetVillaNumbers()
        {
            try
            {
                //_logger.Log("Getting all villas", "");
                //return Ok(VillaStore.VillaList);
                IEnumerable<VillaNumber> villaList = await _dbVillaNumber.GetAllAsync(includeProperties:"Villa");
                _response.Result = _mapper.Map<List<VillaNumberDTO>>(villaList);
                _response.StatusCode = HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { e.Message.ToString() };
                throw;
            }

            return Ok(_response);
        }

        [HttpGet("{id:int}", Name = "GetVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVillaNumber(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var villa = await _dbVillaNumber.GetAsync(x => x.VillaNo == id);
                if (villa == null)
                {
                    return NotFound();
                }
                _response.Result = _mapper.Map<VillaNumberDTO>(villa);
                _response.StatusCode = HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { e.Message.ToString() };
                throw;
            }
            
            return Ok(_response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVillaNumber([FromBody] VillaNumberCreateDTO createDTO)
        {
            try
            {
                if (await _dbVillaNumber.GetAsync(x => x.VillaNo == createDTO.VillaNo) != null)
                {
                    ModelState.AddModelError("ErrorMessage", "Villa Already Exists!");
                    return BadRequest(ModelState);
                }
                if (await _dbVilla.GetAsync(x=>x.Id == createDTO.VillaID) == null)
                {
                    ModelState.AddModelError("ErrorMessage", "Villa ID is invalid!");
                    return BadRequest(ModelState);
                }
                if (createDTO == null)
                {
                    return BadRequest();
                }
                VillaNumber villaNumber = _mapper.Map<VillaNumber>(createDTO);
                villaNumber.CreatedDate = DateTime.Now;
                await _dbVillaNumber.CreateAsync(villaNumber);
                _response.Result = _mapper.Map<VillaNumberDTO>(villaNumber);
                _response.StatusCode = HttpStatusCode.Created;

                return CreatedAtRoute("GetVillaNumber", new { id = villaNumber.VillaNo }, _response);
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { e.Message.ToString() };
                throw;
            }
        }

        [HttpDelete("{id:int}", Name = "DeleteVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteVillaNumber(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var villaNumber = await _dbVillaNumber.GetAsync(x => x.VillaNo == id);
                if (villaNumber == null)
                {
                    return NotFound();
                }
                await _dbVillaNumber.RemoveAsync(villaNumber);
                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { e.Message.ToString() };
                throw;
            }
        }

        [HttpPut("{id:int}", Name = "UpdateVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateVilla(int id, [FromBody] VillaNumberUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.VillaNo)
                {
                    return BadRequest();
                }
                if (await _dbVilla.GetAsync(x => x.Id == updateDTO.VillaID) == null)
                {
                    ModelState.AddModelError("ErrorMessage", "Villa ID is invalid!");
                    return BadRequest(ModelState);
                }
                VillaNumber model = _mapper.Map<VillaNumber>(updateDTO);
                model.UpdatedDate = DateTime.Now;
                await _dbVillaNumber.UpdateAsync(model);
                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { e.Message.ToString() };
                throw;
            }
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialVillaNumber")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            var villa = _dbVillaNumber.GetAsync(x=>x.VillaNo == id, tracked:false);
            if (villa == null)
            {
                return BadRequest();
            }
            VillaUpdateDTO villaDTO = _mapper.Map<VillaUpdateDTO>(villa);
            patchDTO.ApplyTo(villaDTO, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            VillaNumber model = _mapper.Map<VillaNumber>(villaDTO);
            model.UpdatedDate = DateTime.Now;
            await _dbVillaNumber.UpdateAsync(model);

            return NoContent();
        }
    }
}
