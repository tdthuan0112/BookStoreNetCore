"use server";
import { redirect } from "next/navigation";
import { revalidatePath } from "next/cache";

import { CART_API } from "@/api";
import { getAdminUserAction } from "./user-actions";

export async function getCartAction() {
  const adminUser = await getAdminUserAction();
  const adminId = adminUser.userId;

  return await CART_API.getCart(adminId);
}
export async function addToCartAction(userId, bookId, formData) {
  const adminUser = await getAdminUserAction();
  const adminId = adminUser.userId;
  let quantity = 1;
  if (formData != null) {
    quantity = formData.get("quantity");
  }
  await CART_API.addToCart(adminId, bookId, quantity);
  revalidatePath("/cart");
}

export async function buyNowAction(userId, bookId, formData) {
  addToCartAction(userId, bookId, formData);
  redirect("/cart");
}

export async function deleteCartAction(userId, bookId) {
  const adminUser = await getAdminUserAction();
  const adminId = adminUser.userId;
  await CART_API.deleteCart(adminId, bookId);
  revalidatePath("/cart");
}

export async function updateCartAction(userId, bookId, quantity) {
  console.log("UPDATEEEEEEE");
  const adminUser = await getAdminUserAction();
  const adminId = adminUser.userId;

  await CART_API.updateCart(adminId, bookId, quantity);
  revalidatePath("/cart");
}
