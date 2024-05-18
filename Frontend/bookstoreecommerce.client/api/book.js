import RestApiConnection from "@/api/rest-api-connection";
class BookApi extends RestApiConnection {
  constructor() {
    super("book");
  }

  async getAllBook() {
    return await super.get("GetAllBooks", {});
  }
}

export default BookApi;
