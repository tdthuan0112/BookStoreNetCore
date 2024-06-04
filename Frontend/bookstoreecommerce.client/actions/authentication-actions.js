"use server";

import { cookies } from "next/headers";
import { redirect } from "next/navigation";

import { AUTHENTICATION_API } from "@/api/index.js";
import {
  isEmptyOrNull,
  isHasError,
  isNullOrUndefined,
} from "@/lib/helper/common-helper";

export async function loginAction(formData) {
  const data = Object.fromEntries(formData);
  const response = await AUTHENTICATION_API.login(data);
  if (!isHasError(response.code)) {
    const responseData = response.data;
    cookies().set("token", responseData.token);
    cookies().set("expiration", responseData.expiration);
    const callbackCookie = cookies().get("callbackUrl");
    if (!isEmptyOrNull(callbackCookie) && !isNullOrUndefined(callbackCookie)) {
      cookies().delete("callbackUrl");
      redirect(callbackCookie.value);
    }
  }
  redirect("/");
}

function getTokenDuration() {
  const expirationCookie = cookies().get("expiration");
  let storedExpirationDate;
  if (!isNullOrUndefined(expirationCookie))
    storedExpirationDate = expirationCookie.value;
  const expirationDate = new Date(storedExpirationDate);
  const now = new Date();
  const duration = expirationDate.getTime() - now.getTime();

  return duration;
}

export async function isAuthenticatedAction() {
  const tokenCookie = cookies().get("token");
  let token;
  if (!isNullOrUndefined(tokenCookie)) token = tokenCookie.value;
  const tokenDuration = getTokenDuration();
  if (token && tokenDuration > 0) return true;
  return false;
}

export async function checkAuth(currentRoute) {
  const isAuthenticated = await isAuthenticatedAction();
  if (!isAuthenticated) {
    cookies().set("callbackUrl", currentRoute);
    redirect("/buyer/login");
  }
  return true;
}

export async function logoutAction() {
  cookies().delete("token");
  cookies().delete("expiration");
  redirect("/");
}
