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

  async GetAllOrders() {
    return await super.get(`GetAllOrders`);
  }
}

export default OrderApi;
