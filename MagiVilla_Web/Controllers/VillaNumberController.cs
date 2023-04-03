using AutoMapper;
using MagiVilla_Web.Models;
using MagiVilla_Web.Models.DTO;
using MagiVilla_Web.Models.VM;
using MagiVilla_Web.Services;
using MagiVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MagiVilla_Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly IVillaNumberService _villaNumberService;
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;
        public VillaNumberController(IVillaNumberService villaNumberService, IVillaService villaService, IMapper mapper)
        {
            _villaNumberService = villaNumberService;
            _villaService = villaService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexVillaNumber()
        {
            List<VillaNumberDTO> list = new();
            var response = await _villaNumberService.GetAllAsync<APIResponseModel>();
            if (response != null)
            {
                list = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

        public async Task<IActionResult> CreateNewVillaNumberAsync()
        {
            VillaNumberCreateVM viewModel = new ();
            var response = await _villaService.GetAllAsync<APIResponseModel>();
            if (response != null)
            {
                viewModel.VillaList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result)).Select(x=>new SelectListItem
                {
                    Text  = x.Name,
                    Value = x.Id.ToString(),
                });
            }
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNewVillaNumber(VillaNumberCreateVM vm)
        {
            if (ModelState.IsValid)
            {
                var response = await _villaNumberService.CreateAsync<APIResponseModel>(vm.VillaNumber);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVillaNumber));
                }
            }
            return View(vm);
        }

        public async Task<IActionResult> UpdateVilla(int villaNo)
        {
            VillaNumberUpdateVM viewModel = new();
            var response = await _villaNumberService.GetAsync<APIResponseModel>(villaNo);
            if (response != null && response.IsSuccess)
            {
                VillaNumberDTO model = JsonConvert.DeserializeObject<VillaNumberDTO>(Convert.ToString(response.Result));
                viewModel.VillaNumber = _mapper.Map<VillaNumberUpdateDTO>(model);
                return View(viewModel);
            }

            return NotFound();
        }

        //[HttpPost]
        //public async Task<IActionResult> UpdateVilla(VillaNumberUpdateDTO vm)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var response = await _villaService.UpdateAsync<APIResponseModel>(vm.);
        //        if (response != null && response.IsSuccess)
        //        {
        //            return RedirectToAction(nameof(IndexVilla));
        //        }
        //    }
        //    return View(vm);
        //}
    }
}
