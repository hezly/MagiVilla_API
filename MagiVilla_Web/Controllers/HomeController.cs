using AutoMapper;
using MagiVilla_Utility;
using MagiVilla_Web.Models;
using MagiVilla_Web.Models.DTO;
using MagiVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace MagiVilla_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;
        public HomeController(IVillaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<VillaDTO> list = new();
            var response = await _villaService.GetAllAsync<APIResponseModel>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }


    }
}