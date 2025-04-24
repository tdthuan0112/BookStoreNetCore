"use server";

import { redirect } from "next/navigation";
import { revalidatePath } from "next/cache";
import { cookies } from "next/headers";

import { CART_API } from "@/api";
import { getUserDetailAction } from "./user-actions";
import { isEmptyObject, isNullOrUndefined } from "@/lib/helper/common-helper";
import { checkAuth } from "./authentication-actions";

export async function handleClickCartIcon(pathname) {
  const isAuthenticated = await checkAuth(pathname);
  if (isAuthenticated) redirect("/cart");
}

export async function getCartAction(isRedirectCartPage = false) {
  const user = await getUserDetailAction();
  if (isNullOrUndefined(user)) redirect("/");
  const userId = user.userId;
  const response = await CART_API.getCart(userId);
  const cart = response.data;
  if (
    (isNullOrUndefined(cart) ||
      isNullOrUndefined(cart?.cartItems) ||
      isEmptyObject(cart.cartItems)) &&
    isRedirectCartPage
  ) {
    redirect("/cart");
  }
  return cart;
}
export async function addToCartAction(callbackUrl, bookId, formData) {
  await checkAuth(callbackUrl);
  const user = await getUserDetailAction();
  if (isNullOrUndefined(user)) redirect("/");
  console.log(user);
  const userId = user.userId;
  let quantity = 1;
  if (formData != null) {
    quantity = formData.get("quantity");
  }
  await CART_API.addToCart(userId, bookId, quantity);
  revalidatePath("/cart");
}

export async function buyNowAction(callbackUrl, bookId, formData) {
  addToCartAction(callbackUrl, bookId, formData);
  redirect("/cart");
}

export async function deleteCartAction(bookId) {
  const user = await getUserDetailAction();
  if (isNullOrUndefined(user)) redirect("/");
  const userId = user.userId;
  await CART_API.deleteCart(userId, bookId);
  revalidatePath("/cart");
}

export async function updateCartAction(bookId, quantity) {
  const user = await getUserDetailAction();
  if (isNullOrUndefined(user)) redirect("/");
  const userId = user.userId;

  await CART_API.updateCart(userId, bookId, quantity);
  revalidatePath("/cart");
}
