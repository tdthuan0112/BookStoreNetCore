"use server";

import { USER_API } from "@/api";
import {
  isEmptyOrNull,
  isHasError,
  isNullOrUndefined,
} from "@/lib/helper/common-helper";
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

//GET CURRENT USER LOGGED IN
export async function getCurrentUserLoggedInAction() {
  const tokenCookie = cookies().get("token");
  let token;
  if (!isNullOrUndefined(tokenCookie)) token = tokenCookie.value;
  else token = "";
  const config = {
    headers: {
      Authorization: `Bearer ${token}`,
    },
  };
  const response = await USER_API.getUserDetail(config);
  if (!isHasError(response)) {
    return response.data;
  } else {
    return null;
  }
}

export async function deleteUserByUserIdAction(formData) {
  const data = Object.fromEntries(formData);
  const response = await USER_API.deleteUserByUserId(data.userId);
  redirect("admin/manage-users");
}

export async function updateUserDetail(formData) {
  const data = Object.fromEntries(formData);
  const payload = {
    ...data,
    gender: parseInt(data.gender)
  };
  console.log(payload)
  const response = await USER_API.updateUserDetail(payload);
  console.log(response)
  //CHECK ERROR OF RESPONSE HERE
  redirect(`/admin/manage-users/${data.userId}`);
}