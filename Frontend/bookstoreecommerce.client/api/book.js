import RestApiConnection from "@/api/rest-api-connection";
class BookApi extends RestApiConnection {
  constructor() {
    super("book");
  }

  getAllBook() {
    return super.get("GetAllBooks", {});
  }
}

export default BookApi;
