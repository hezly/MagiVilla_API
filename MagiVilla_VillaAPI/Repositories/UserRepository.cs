using MagiVilla_VillaAPI.Data;
using MagiVilla_VillaAPI.Models.DTO;
using MagiVilla_VillaAPI.Repositories.IRepository;
using MagiVilla_WebAPI.Models;

namespace MagiVilla_VillaAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool IsUniqueUser(string username)
        {
            var user = _db.LocaUsers.FirstOrDefault(x => x.UserName == username);
            if (user == null)
            {
                return true;
            }
            return false;
        }

        public Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<LocaUser> Register(RegisterationRequestDTO registerationRequestDTO)
        {
            LocaUser user = new()
            {
                UserName = registerationRequestDTO.UserName,
                Password = registerationRequestDTO.Password,
                Name = registerationRequestDTO.Name,
                Role = registerationRequestDTO.Role,
            };

            _db.LocaUsers.Add(user);
            await _db.SaveChangesAsync();
            user.Password = "";
            return user;
        }
    }
}
