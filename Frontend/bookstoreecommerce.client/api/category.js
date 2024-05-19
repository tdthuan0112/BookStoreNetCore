import RestApiConnection from "./rest-api-connection";

class CategoryApi extends RestApiConnection {
  constructor() {
    super("category");
  }

  async getAllCategories() {
    return await super.get("getAllCategories");
  }
}

export default CategoryApi;
