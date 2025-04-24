import RestApiConnection from "./rest-api-connection";

class OrderApi extends RestApiConnection {
  constructor() {
    super("order");
  }

  async getAllUserOrders(userId) {
    return await super.post(`GetAllUserOrders?userId=${userId}`);
  }

  async submitOrder(data) {
    return await super.post("SubmitOrder", data);
  }

  async getOrderDetailByOrderId(orderId) {
    return await super.get(`GetOrderDetailByOrderId?orderId=${orderId}`);
  }

  async GetAllOrders(userId, orderId) {
    let url = "GetAllOrders";
    if (userId && orderId)
      url = `GetAllOrders?userId=${userId}&orderId=${orderId}`;
    else if (userId) {
      url = `GetAllOrders?userId=${userId}`;
    } else if (orderId) url = `GetAllOrders?orderId=${orderId}`;
    return await super.get(url);
  }
}

export default OrderApi;
