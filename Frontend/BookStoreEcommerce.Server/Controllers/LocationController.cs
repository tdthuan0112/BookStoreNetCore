using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreEcommerce.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : BaseController
    {
        private ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet("GetAllProvinces")]
        public IActionResult GetAllProvinces()
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _locationService.GetAllProvinces();
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpGet("GetDistrictByProvinceId/{provinceId}")]
        public IActionResult GetDistrictByProvinceId(string provinceId)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _locationService.GetDistrictByProvinceId(provinceId);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }

        [HttpGet("GetWardByDistrictId/{districtId}")]
        public IActionResult GetWardByDistrictId(string districtId)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _locationService.GetWardByDistrictId(districtId);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }
        
        [HttpGet("GetFullNameLocationById/{locationId}")]
        public IActionResult GetFullNameLocationById(string locationId)
        {
            var responseModel = new BaseResponseModel();
            BaseResponseErrorModel baseResponseErrorModel = new();
            var result = _locationService.GetFullNameLocationById(locationId);
            responseModel.Data = result;
            responseModel.SetResponseError(baseResponseErrorModel);
            return ReturnData(responseModel);
        }
    }
}
