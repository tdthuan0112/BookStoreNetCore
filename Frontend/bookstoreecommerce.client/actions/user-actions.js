"use server";

import { USER_API } from "@/api";

export async function getAllUsersAction() {
  return await USER_API.getAllUsers();
}

export async function getAdminUserAction() {
  const listUser = await getAllUsersAction();
  return listUser[0];
}

export async function getUserDetailByIdAction(userId) {
  return await USER_API.getUserDetailById(userId);
}
