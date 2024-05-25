"use server";

import { ORDER_API } from "@/api/index";
import { getAdminUserAction } from "./user-actions";
import { redirect } from "next/navigation";

export async function submitOrderAction(data) {
  const adminUser = await getAdminUserAction();
  const adminId = adminUser.userId;
  let submitData = {
    userId: adminId,
    userNote: "Nothing to NOTE here",
    address: "123 Highway 1k Binh An",
    ward: "Di An",
    district: "Binh Duong",
    shippingMethod: 0,
    paymentMethod: 0,
  };
  const result = await ORDER_API.submitOrder(submitData);
  redirect(`/order-success/${result.orderId}`);
}

export async function getAllUserOrdersAction(userId) {
  const adminUser = await getAdminUserAction();
  const adminId = adminUser.userId;
  return await ORDER_API.getAllUserOrders(adminId);
}

export async function getOrderDetailByIdAction(orderId) {
  return await ORDER_API.getOrderDetailByOrderId(orderId);
}

export async function GetAllOrdersAction(userId, orderId) {
  return await ORDER_API.GetAllOrders(userId, orderId);
}
