using Microsoft.AspNetCore.Mvc;
using static MagiVilla_Utility.SD;

namespace MagiVilla_Web.Models
{
    public class APIRequestModel
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string Token { get; set; }
    }
}