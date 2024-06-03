using BookStore.BLL.Extensions;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models.Response;

namespace BookStore.BLL.Services
{
    public class LocationService : ILocationService
    {
        private readonly string baseUrl = "https://esgoo.net/api-tinhthanh";
        public LocationService() { }

        public List<LocationModel> GetAllProvinces()
        {
            List<LocationModel> listProvinces = new();
            var response = HttpClientExt.Get<ResponseApiMultiLocations>(baseUrl, "/1/0.htm");
            if (response != null && response.Error == 0)
            {
                if(response.Data != null)
                {
                    foreach (var item in response.Data)
                    {
                        var location = new LocationModel
                        {
                            Id = item.Id,
                            Value = item.Name
                        };
                        listProvinces.Add(location);
                    }
                }
            }
            return [.. listProvinces.OrderBy(x => x.Value)];
        }

        public List<LocationModel> GetDistrictByProvinceId(string provinceId)
        {
            List<LocationModel> listDistricts = new();
            var response = HttpClientExt.Get<ResponseApiMultiLocations>(baseUrl, $"/2/{provinceId}.htm");
            if (response != null && response.Error == 0)
            {
                if (response.Data != null)
                {
                    foreach (var item in response.Data)
                    {
                        var location = new LocationModel
                        {
                            Id = item.Id,
                            Value = item.Name.IsDigitsOnly() ? item.Full_Name : item.Name
                        };
                        listDistricts.Add(location);
                    }
                }
            }
            return [.. listDistricts.OrderBy(x => x.Value)];
        }

        public List<LocationModel> GetWardByDistrictId(string districtId)
        {
            List<LocationModel> listWards = new();
            var response = HttpClientExt.Get<ResponseApiMultiLocations>(baseUrl, $"/3/{districtId}.htm");
            if (response != null && response.Error == 0)
            {
                if (response.Data != null)
                {
                    foreach (var item in response.Data)
                    {
                        var location = new LocationModel
                        {
                            Id = item.Id,
                            Value = item.Name.IsDigitsOnly() ? item.Full_Name : item.Name
                        };
                        listWards.Add(location);
                    }
                }
            }
            return [.. listWards.OrderBy(x => x.Value)];
        }

        public LocationModel GetFullNameLocationById(string locationId)
        {
            LocationModel locationData = new();
            var response = HttpClientExt.Get<ResponseApiLocation>(baseUrl, $"/5/{locationId}.htm");
            if (response != null && response.Error == 0)
            {
                if (response.Data != null)
                {
                    locationData = new LocationModel
                    {
                        Id = locationId,
                        Value = response.Data.Full_Name_En
                    };
                }
            }
            return locationData;
        }
    }
}
