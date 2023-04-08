using MagiVilla_WebAPI.Models;

namespace MagiVilla_VillaAPI.Models
{
    public class LoginResponse
    {
        public LocaUser User { get; set; }
        public string Token { get; set; }
    }
}
