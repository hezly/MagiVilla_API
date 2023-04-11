using MagiVilla_Utility;
using MagiVilla_Web.Models;
using MagiVilla_Web.Models.DTO;
using MagiVilla_Web.Services.IServices;
using Newtonsoft.Json.Linq;

namespace MagiVilla_Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string _villaUrl;
        public VillaService(IHttpClientFactory httpClient, IConfiguration configuration) : base(httpClient)
        {
            _httpClientFactory = httpClient;
            _villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateAsync<T>(VillaCreateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequestModel
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = $"{_villaUrl}/api/villaAPI",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequestModel
            {
                ApiType = SD.ApiType.DELETE,
                Url = $"{_villaUrl}/api/villaAPI/{id}",
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequestModel
            {
                ApiType = SD.ApiType.GET,
                Url = $"{_villaUrl}/api/villaAPI",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequestModel
            {
                ApiType = SD.ApiType.GET,
                Url = $"{_villaUrl}/api/villaAPI/{id}",
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequestModel 
            { 
                ApiType = SD.ApiType.PUT, 
                Data = dto,
                Url = $"{_villaUrl}/api/villaAPI/{dto.Id}",
                Token = token
            });
        }
    }
}
