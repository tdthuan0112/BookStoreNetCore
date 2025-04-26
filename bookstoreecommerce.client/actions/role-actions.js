import { ROLE_API } from "@/api";

export async function getAllRolesAction() {
    const response = await ROLE_API.getAllRoles();
    return response.data;
  }
  
  export async function getRoleDetailByIdAction(roleId) {
    const response = await ROLE_API.getRoleDetailById(roleId);
    return response.data;
  }