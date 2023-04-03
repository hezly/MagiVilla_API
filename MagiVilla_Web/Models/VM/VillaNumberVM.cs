using MagiVilla_Web.Models.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagiVilla_Web.Models.VM
{
    public class VillaNumberVM
    {
    }

    public class VillaNumberCreateVM
    {
        public VillaNumberCreateVM()
        {
            VillaNumber = new VillaNumberCreateDTO();
        }
        public VillaNumberCreateDTO VillaNumber { get; set; }
        public IEnumerable<SelectListItem> VillaList { get; set; }
    }

    public class VillaNumberUpdateVM
    {
        public VillaNumberUpdateVM()
        {
            VillaNumber = new VillaNumberUpdateDTO();
        }
        public VillaNumberUpdateDTO VillaNumber { get; set; }
        public IEnumerable<SelectListItem> VillaList { get; set; }
    }
}
