using MagiVilla_Utility;
using MagiVilla_Web.Models;
using MagiVilla_Web.Models.DTO;
using MagiVilla_Web.Services.IServices;

namespace MagiVilla_Web.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string _villaUrl;
        public AuthService(IHttpClientFactory httpClient, IConfiguration configuration) : base(httpClient)
        {
            _httpClientFactory = httpClient;
            _villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> LoginAsync<T>(LoginRequestDTO obj)
        {
            return SendAsync<T>(new APIRequestModel
            {
                ApiType = SD.ApiType.POST,
                Data = obj,
                Url = $"{_villaUrl}/api/UserAuth/login",
            });
        }

        public Task<T> RegisterAsync<T>(RegisterationRequestDTO obj)
        {
            return SendAsync<T>(new APIRequestModel
            {
                ApiType = SD.ApiType.POST,
                Data = obj,
                Url = $"{_villaUrl}/api/UserAuth/register",
            });
        }
    }
}
