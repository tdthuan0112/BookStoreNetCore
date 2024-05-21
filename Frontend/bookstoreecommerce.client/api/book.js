import RestApiConnection from "@/api/rest-api-connection";
class BookApi extends RestApiConnection {
  constructor() {
    super("book");
  }

  async getAllBook() {
    return await super.get("GetAllBooks", {});
  }

  async getBookByCategoryUrl(categoryUrl) {
    return await super.get(`GetBooksByCategoryUrl/${categoryUrl}`, {});
  }

  async getBookDetailByUrl(bookUrl) {
    return await super.get(`GetBookDetailByUrl/${bookUrl}`, {});
  }
}

export default BookApi;
