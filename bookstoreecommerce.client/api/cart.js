import RestApiConnection from "@/api/rest-api-connection";
class CartApi extends RestApiConnection {
  constructor() {
    super("cart");
  }

  async getCart(userId) {
    return await super.get(`GetCart?userId=${userId}`);
  }

  async addToCart(userId, bookId, quantity = 1) {
    return await super.post(`AddToCart`, {
      userId,
      bookId,
      quantity,
    });
  }

  async deleteCart(userId, bookId) {
    return await super.delete(`deleteCart`, {
      userId,
      bookId,
    });
  }

  async updateCart(userId, bookId, quantity) {
    return await super.post(`updateCart`, {
      userId,
      bookId,
      quantity,
    });
  }
}

export default CartApi;
