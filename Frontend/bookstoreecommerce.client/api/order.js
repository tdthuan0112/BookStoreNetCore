import RestApiConnection from "./rest-api-connection";

class OrderApi extends RestApiConnection {
  constructor() {
    super("order");
  }

  async submitOrder(data) {
    return await super.post("SubmitOrder", data);
  }

  async getOrderDetailByOrderId(orderId) {
    return await super.get(`GetOrderDetailByOrderId?orderId=${orderId}`);
  }
}

export default OrderApi;
