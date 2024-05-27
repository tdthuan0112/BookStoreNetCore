import RestApiConnection from "./rest-api-connection";

class CategoryApi extends RestApiConnection {
  constructor() {
    super("category");
  }

  async getAllCategories() {
    return await super.get("GetAllCategories");
  }

  async getAllActiveCategories() {
    return await super.get("GetAllActiveCategories");
  }

  async getCategoryDetailById(categoryId) {
    return await super.get(`GetCategoryDetailById/${categoryId}`);
  }

  async deleteCategory(categoryId) {
    return await super.delete(`DeleteCategory`, categoryId);
  }

  async updateCategory(payload) {
    return await super.post(`UpdateCategory`, payload);
  }

  async addNewCategory(payload) {
    return await super.post(`AddNewCategory`, payload);
  }
}

export default CategoryApi;
