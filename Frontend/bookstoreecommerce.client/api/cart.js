import RestApiConnection from "@/api/rest-api-connection";
import { USER_API } from ".";

class CartApi extends RestApiConnection {
  constructor() {
    super("cart");
  }

  async getCart(userId) {
    const listUsers = await USER_API.getAllUsers();
    return await super.get(`GetCart/?userId=${listUsers[0].userId}`);
  }

  async addToCart(bookId, quantity = 1) {
    const listUsers = await USER_API.getAllUsers();

    return await super.post(`AddToCart`, {
      userId: listUsers[0].userId,
      bookId,
      quantity,
    });
  }
}

export default CartApi;
