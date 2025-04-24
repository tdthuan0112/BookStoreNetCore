"use server";

import { LOCATION_API } from "@/api/index";

export async function getAllProvincesAction() {
  const result = await LOCATION_API.getAllProvinces();
  return result.data;
}

export async function getDistrictByProvinceIdAction(provinceId) {
  const result = await LOCATION_API.getDistrictByProvinceId(provinceId);
  return result.data;
}

export async function getWardByDistrictIdAction(districtId) {
  const result = await LOCATION_API.getWardByDistrictId(districtId);
  return result.data;
}
