"use server";

import { ORDER_API } from "@/api/index";
import { getCurrentUserLoggedInAction } from "./user-actions";
import { redirect } from "next/navigation";

export async function submitOrderAction(data) {
  const user = await getCurrentUserLoggedInAction();
  const userId = user.userId;
  let submitData = {
    userId: userId,
    userNote: "Nothing to NOTE here",
    address: "123 Highway 1k Binh An",
    ward: "Di An",
    district: "Binh Duong",
    shippingMethod: 0,
    paymentMethod: 0,
  };
  const response = await ORDER_API.submitOrder(submitData);
  const result = response.data;
  redirect(`/order-success/${result.orderId}`);
}

export async function getAllUserOrdersAction() {
  const user = await getCurrentUserLoggedInAction();
  const userId = user.userId;
  const response = await ORDER_API.getAllUserOrders(userId);
  return response.data;
}

export async function getOrderDetailByIdAction(orderId) {
  const response = await ORDER_API.getOrderDetailByOrderId(orderId);
  return response.data;
}

export async function GetAllOrdersAction(userId, orderId) {
  const response = await ORDER_API.GetAllOrders(userId, orderId);
  return response.data;
}
