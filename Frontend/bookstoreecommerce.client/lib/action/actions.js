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
