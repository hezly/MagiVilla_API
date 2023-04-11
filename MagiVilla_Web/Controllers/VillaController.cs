using AutoMapper;
using MagiVilla_Utility;
using MagiVilla_Web.Models;
using MagiVilla_Web.Models.DTO;
using MagiVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagiVilla_Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;
        public VillaController(IVillaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }

        public async Task<IActionResult> IndexVilla()
        {
            List<VillaDTO> list = new();
            var response = await _villaService.GetAllAsync<APIResponseModel>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
        [Authorize(Roles = "admin")]
        public IActionResult CreateVilla()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVilla(VillaCreateDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _villaService.CreateAsync<APIResponseModel>(model, HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess) 
                {
                    TempData["success"] = "Villa created successfully.";
                    return RedirectToAction(nameof(IndexVilla));
                }
            }
            TempData["error"] = "Error encountered.";
            return View(model);
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateVilla(int villaId)
        {
            var response = await _villaService.GetAsync<APIResponseModel>(villaId, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess) {
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
                return View(_mapper.Map<VillaUpdateDTO>(model));
            }

            return NotFound();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateVilla(VillaUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _villaService.UpdateAsync<APIResponseModel>(model, HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    TempData["success"] = "Villa updated successfully.";
                    return RedirectToAction(nameof(IndexVilla));
                }
            }
            TempData["error"] = "Error encountered.";
            return View(model);
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteVilla(int villaId)
        {
            var response = await _villaService.GetAsync<APIResponseModel>(villaId, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
                return View(model);
            }

            return NotFound();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> DeleteVilla(VillaDTO model)
        {
            var response = await _villaService.DeleteAsync<APIResponseModel>(model.Id, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                TempData["success"] = "Villa deleted successfully.";
                return RedirectToAction(nameof(IndexVilla));
            }
            TempData["error"] = "Error encountered.";
            return View(model);
        }
    }
}
;