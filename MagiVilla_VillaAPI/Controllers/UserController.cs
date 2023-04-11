using MagiVilla_VillaAPI.Models;
using MagiVilla_VillaAPI.Models.DTO;
using MagiVilla_VillaAPI.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MagiVilla_VillaAPI.Controllers
{
    [Route("api/v{version:apiVersion}/UserAuth")]
    [ApiController]
    [ApiVersionNeutral]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;
        protected APIResponse _response;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
            this._response = new APIResponse();
        }

        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO model)
        {
            var loginResponse = await _userRepo.Login(model);
            if (loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessage.Add("Username or password is incorrect");
                return BadRequest(_response);
            }
            _response.StatusCode = HttpStatusCode.OK;
            _response.IsSuccess = true;
            _response.Result = loginResponse;
            return Ok(_response);
        }

        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromBody] RegisterationRequestDTO model)
        {
            bool isUsernameUnique = _userRepo.IsUniqueUser(model.UserName);
            if (!isUsernameUnique)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessage.Add("Username already exists");
                return BadRequest(_response);
            }
            var user = await _userRepo.Register(model);
            if (user == null)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessage.Add("Error while registering");
                return BadRequest(_response);
            }
            _response.StatusCode = HttpStatusCode.OK;
            _response.IsSuccess = true;
            return Ok(_response);
        }
    }
}
