import RestApiConnection from "./rest-api-connection";

class LocationApi extends RestApiConnection {
  constructor() {
    super("location");
  }

  async getAllProvinces() {
    return await super.get(`GetAllProvinces`);
  }

  async getDistrictByProvinceId(provinceId) {
    return await super.get(`GetDistrictByProvinceId/${provinceId}`);
  }

  async getWardByDistrictId(districtId) {
    return await super.get(`GetWardByDistrictId/${districtId}`);
  }
}

export default LocationApi;
