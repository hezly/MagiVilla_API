using MagiVilla_Web.Models;

namespace MagiVilla_Web.Services.IServices
{
    public interface IBaseService
    {
        APIResponseModel responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequestModel apiRequestModel);
    }
}
