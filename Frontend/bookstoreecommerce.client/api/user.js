import RestApiConnection from "@/api/rest-api-connection";
class UserApi extends RestApiConnection {
  constructor() {
    super("User");
  }
  async getAllUsers() {
    return await super.get("GetAllUsers", {});
  }

  async getUserDetailById(userId) {
    return await super.get(`GetUserDetailById?userId=${userId}`, {});
  }

  async createUser(payload) {
    return await super.post(`CreateUser`, payload);
  }

  async getUserDetail(config) {
    return await super.get(`getUserDetail`, {}, config);
  }

  async deleteUserByUserId(payload) {
    return await super.delete(`DeleteUserByUserId`, payload);
  }
}

export default UserApi;
