using BookStore.BLL.Models.Response;

namespace BookStore.BLL.Interfaces
{
    public interface ILocationService
    {
        List<LocationModel> GetAllProvinces();
        List<LocationModel> GetDistrictByProvinceId(string provinceId);
        List<LocationModel> GetWardByDistrictId(string districtId);
        LocationModel GetFullNameLocationById(string locationId);
    }
}
