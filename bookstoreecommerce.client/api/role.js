import RestApiConnection from "./rest-api-connection";

class RoleApi extends RestApiConnection {
  constructor() {
    super("Role");
  }

  async getAllRoles() {
    return await super.get(`GetAllRoles`, {});
  }

  async getRoleDetailById(roleId){
    return await super.get(`GetRoleDetailById/${roleId}`, {});
  }
}

export default RoleApi;
