import RestApiConnection from "@/api/rest-api-connection";
class AuthenticationApi extends RestApiConnection {
  constructor() {
    super("authentication");
  }

  async login(payload) {
    return await super.post(`login`, payload);
  }
}

export default AuthenticationApi;
