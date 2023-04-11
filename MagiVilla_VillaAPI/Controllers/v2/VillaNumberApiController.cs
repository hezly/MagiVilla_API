using AutoMapper;
using Azure;
using MagiVilla_VillaAPI.Data;
using MagiVilla_VillaAPI.Logging;
using MagiVilla_VillaAPI.Models;
using MagiVilla_VillaAPI.Repositories.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net;

namespace MagiVilla_VillaAPI.Controllers.v2
{
    //[Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
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

        [HttpGet("GetString")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Bhrugen", "DotNetMastery" };
        }
    }
}
