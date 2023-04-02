using MagiVilla_Utility;
using MagiVilla_Web.Models;
using MagiVilla_Web.Services.IServices;
using Newtonsoft.Json;
using System;
using System.Text;

namespace MagiVilla_Web.Services
{
    public class BaseService : IBaseService
    {

        public APIResponseModel responseModel { get; set; }
        public IHttpClientFactory httpClient { get; set; }
        public BaseService(IHttpClientFactory httpClient) 
        {
            this.responseModel = new APIResponseModel();
            this.httpClient = httpClient;
        }

        public async Task<T> SendAsync<T>(APIRequestModel apiRequestModel)
        {
            try
            {
                var client = httpClient.CreateClient("MagicAPI");
                HttpRequestMessage message = new ();
                message.Headers.Add ("Accept", "application/json");
                message.RequestUri = new Uri(apiRequestModel.Url);
                if (apiRequestModel.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequestModel.Data), Encoding.UTF8, "application/json");
                }
                switch (apiRequestModel.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }
                HttpResponseMessage response = null;
                response = await client.SendAsync(message);
                var apiContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(apiContent);
            }
            catch (Exception e)
            {
                var dto = new APIResponseModel
                {
                    ErrorMessage = new List<string> { e.Message.ToString() },
                    IsSuccess = false,
                };
                var res = JsonConvert.SerializeObject(dto);
                return JsonConvert.DeserializeObject<T>(res);
            }
        }
    }
}
