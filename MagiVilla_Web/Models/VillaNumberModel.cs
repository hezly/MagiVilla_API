using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MagiVilla_Web.Models
{
    public class VillaNumberModel
    {
        public int VillaNo { get; set; }
        public int VillaID { get; set; }
        public VillaModel Villa { get; set; }
        public string SpecialDetails { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
