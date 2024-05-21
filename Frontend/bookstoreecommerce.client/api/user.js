import RestApiConnection from "@/api/rest-api-connection";
class UserApi extends RestApiConnection {
  constructor() {
    super("User");
  }
  async getAllUsers() {
    return await super.get("GetAllUsers", {});
  }
}

export default UserApi;
