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
}

export default UserApi;
