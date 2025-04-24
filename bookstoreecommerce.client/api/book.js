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

  async getBookDetailByBookId(bookId) {
    return await super.get(`getBookDetailByBookId/${bookId}`, {});
  }

  async updateBookDetail(payload) {
    return await super.post(`UpdateBookDetail`, payload);
  }

  async deleteBook(bookId) {
    return await super.delete(`DeleteBook`, bookId);
  }

  async addNewBook(payload) {
    return await super.post(`AddNewBook`, payload);
  }
}

export default BookApi;
