using MagiVilla_VillaAPI.Models.DTO;
using MagiVilla_WebAPI.Models;

namespace MagiVilla_VillaAPI.Repositories.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
