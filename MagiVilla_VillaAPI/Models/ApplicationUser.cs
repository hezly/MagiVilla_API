using Microsoft.AspNetCore.Identity;

namespace MagiVilla_VillaAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
