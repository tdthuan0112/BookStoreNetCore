"use server";

import { USER_API } from "@/api";
import { isNullOrUndefined } from "@/lib/helper/common-helper";
import { cookies } from "next/headers";
import { redirect } from "next/navigation";

export async function getAllUsersAction() {
  const response = await USER_API.getAllUsers();
  return response.data;
}

export async function getAdminUserAction() {
  const listUser = await getAllUsersAction();
  return listUser[0];
}

export async function getUserDetailByIdAction(userId) {
  const response = await USER_API.getUserDetailById(userId);
  return response.data;
}

export async function createUserAction(formData) {
  const data = Object.fromEntries(formData);
  const payload = {
    userName: data.userName,
    password: data.password,
    firstName: data.firstName,
    lastName: data.lastName,
    email: data.email,
    phoneNumber: data.phoneNumber,
    provinceId: parseInt(data.provinceId),
    provinceName: data.provinceName,
    districtId: parseInt(data.districtId),
    districtName: data.districtName,
    wardId: parseInt(data.wardId),
    wardName: data.wardName,
    address: data.address,
    dateOfBirth: data.dateOfBirth,
  };
  const response = await USER_API.createUser(payload);
  //HANDLE ERROR
  redirect("/buyer/login");
  return response.data;
}

export async function getUserDetailAction() {
  const tokenCookie = cookies().get("token");
  let token;
  if (!isNullOrUndefined(tokenCookie)) token = tokenCookie.value;
  const config = {
    headers: {
      Authorization: `Bearer ${token}`,
    },
  };
  const response = await USER_API.getUserDetail(config);
  return response.data;
}

export async function deleteUserByUserIdAction(formData) {
  const data = Object.fromEntries(formData);
  const response = await USER_API.deleteUserByUserId(data.userId);
  redirect("admin/manage-users");
}
