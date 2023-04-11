using AutoMapper;
using MagiVilla_Utility;
using MagiVilla_Web.Models;
using MagiVilla_Web.Models.DTO;
using MagiVilla_Web.Models.VM;
using MagiVilla_Web.Services;
using MagiVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;

namespace MagiVilla_Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly IVillaNumberService _villaNumberService;
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;
        private readonly string _token;
        public VillaNumberController(IVillaNumberService villaNumberService, IVillaService villaService, IMapper mapper)
        {
            _villaNumberService = villaNumberService;
            _villaService = villaService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexVillaNumber()
        {
            List<VillaNumberDTO> list = new();
            var response = await _villaNumberService.GetAllAsync<APIResponseModel>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null)
            {
                list = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateNewVillaNumberAsync()
        {
            VillaNumberCreateVM vm = new ();
            var response = await _villaService.GetAllAsync<APIResponseModel>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null)
            {
                vm.VillaList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result)).Select(x=>new SelectListItem
                {
                    Text  = x.Name,
                    Value = x.Id.ToString(),
                });
            }
            return View(vm);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNewVillaNumber(VillaNumberCreateVM vm)
        {
            if (ModelState.IsValid)
            {
                var response = await _villaNumberService.CreateAsync<APIResponseModel>(vm.VillaNumber, HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVillaNumber));
                }
                else
                {
                    if (response.ErrorMessage.Count > 0)
                    {
                        ModelState.AddModelError("ErrorMessage", response.ErrorMessage.FirstOrDefault());
                    }
                }
            }
            var getAllVillas = await _villaService.GetAllAsync<APIResponseModel>(HttpContext.Session.GetString(SD.SessionToken));
            if (getAllVillas != null)
            {
                vm.VillaList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(getAllVillas.Result)).Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString(),
                });
            }

            return View(vm);
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateVillaNumber(int villaNo)
        {
            VillaNumberUpdateVM vm = new();
            var response = await _villaNumberService.GetAsync<APIResponseModel>(villaNo, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                VillaNumberDTO model = JsonConvert.DeserializeObject<VillaNumberDTO>(Convert.ToString(response.Result));
                vm.VillaNumber = _mapper.Map<VillaNumberUpdateDTO>(model);
            }
            response = await _villaService.GetAllAsync<APIResponseModel>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                vm.VillaList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result)).Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString(),
                });
                return View(vm);
            }
            return NotFound();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateVillaNumber(VillaNumberUpdateVM vm)
        {
            if (ModelState.IsValid)
            {
                var response = await _villaNumberService.UpdateAsync<APIResponseModel>(vm.VillaNumber, HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVillaNumber));
                }
                else
                {
                    if (response.ErrorMessage.Count > 0)
                    {
                        ModelState.AddModelError("ErrorMessage", response.ErrorMessage.FirstOrDefault());
                    }
                }
                response = await _villaService.GetAllAsync<APIResponseModel>(HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                    vm.VillaList = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result)).Select(x => new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString(),
                    });
                }
            }
            return View(vm);
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteVillaNumber(int villaNo)
        {
            VillaNumberDeleteVM villaNumberVM = new();
            var response = await _villaNumberService.GetAsync<APIResponseModel>(villaNo, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                VillaNumberDTO model = JsonConvert.DeserializeObject<VillaNumberDTO>(Convert.ToString(response.Result));
                villaNumberVM.VillaNumber = model;
            }

            response = await _villaService.GetAllAsync<APIResponseModel>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                villaNumberVM.VillaList = JsonConvert.DeserializeObject<List<VillaDTO>>
                    (Convert.ToString(response.Result)).Select(i => new SelectListItem
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    });
                return View(villaNumberVM);
            }
            return NotFound();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteVillaNumber(VillaNumberDeleteVM vm)
        {
            var response = await _villaNumberService.DeleteAsync<APIResponseModel>(vm.VillaNumber.VillaNo, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexVillaNumber));
            }
            return View(vm);
        }
    }
}
