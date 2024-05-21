"use client";

import { usePathname } from "next/navigation";
import Image from "next/image";

import { capitalizeFirstLetter } from "@/lib/helper/url-helper";

import AuthenticationHeader from "@/components/header-footer/authentication-header";
import MainFooter from "@/components/header-footer/main-footer";
import BuyerBackgroundImg from "@/assets/img/buyer-authentication-background.png";
import AdminBackgroundImg from "@/assets/img/admin-authentication-background.png";

import classes from "@/styles/layout/authentication-layout.module.css";
export default function AuthenticationLayout({ children }) {
  const pathName = usePathname();
  const isAdmin = pathName === "/admin/login";
  let pageUrl = capitalizeFirstLetter(pathName.replace("/buyer/", ""));

  //Rename pageUrl
  if (pageUrl === "Signup") pageUrl = "Sign Up";
  if (isAdmin) pageUrl = "Admin";
  return (
    <div>
      <AuthenticationHeader pageName={pageUrl} />
      <div className={isAdmin ? classes.adminBackground : classes.background}>
        <div className={classes.content}>
          <Image
            src={isAdmin ? AdminBackgroundImg : BuyerBackgroundImg}
            width={isAdmin ? 600 : 700}
            alt="Authentication Background"
          />
          {children}
        </div>
      </div>
      <MainFooter />
    </div>
  );
}
