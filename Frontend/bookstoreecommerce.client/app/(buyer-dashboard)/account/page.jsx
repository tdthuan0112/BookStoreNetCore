"use client";

import AccountInfomation from "@/components/account/account-infomation";
import classes from "@/styles/layout/account-page.module.css";

export default function AccountPage({ searchParams }) {
  //GET ACCOUNT INFO
  //const userInfo = await getUserInfo() ....
  return <AccountInfomation searchParams={searchParams} />;
}
