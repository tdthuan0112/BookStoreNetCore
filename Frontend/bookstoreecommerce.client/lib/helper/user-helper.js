import { USER_API } from "@/api";

export async function getUserAdmin() {
  return await USER_API.getAllUsers()[0];
}
