"use server";

import { redirect } from "next/navigation";

export async function navigateCheckout() {
  redirect(`/checkout`);
}

export async function navigateOrderSuccess() {
  redirect(`/order-success`);
}

export async function navigateAllBooks() {
  redirect(`/all-books`);
}

export async function navigateEditBuyerAccount() {
  redirect(`/account?mode=edit`);
}

export async function navigateAdminOrderDetail(formData) {
  const orderId = formData.get("orderId");
  redirect(`/admin/manage-orders/${orderId}`);
}
