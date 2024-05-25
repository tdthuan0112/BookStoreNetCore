"use client";

import Link from "next/link";
import Image from "next/image";

import { usePathname } from "next/navigation";

import accountImg from "@/assets/img/account.png";
import orderImg from "@/assets/img/order.png";
import creditcardImg from "@/assets/img/creditcard.png";
import locationImg from "@/assets/img/location.png";
import classes from "@/styles/common/account-navigation.module.css";

export default function AccountNavigation() {
  const pathname = usePathname();
  const isAccountPage = pathname === "/account";
  const isOrderPage = pathname === "/account/orders";
  const isBillingPage = pathname === "/account/billings";
  const isAddressPage = pathname === "/account/addresses";
  return (
    <div>
      <div>
        <p>Account of</p>
        <p>
          <strong>Thuan Tran</strong>
        </p>
      </div>
      <Link
        href="/account"
        className={`${classes.navLink} ${
          isAccountPage ? classes.activeLink : undefined
        }`}
      >
        <Image src={accountImg} with={20} height={20} alt="Account Image" />
        <p>Account Infomation</p>
      </Link>
      <Link
        href="/account/orders"
        className={`${classes.navLink} ${
          isOrderPage ? classes.activeLink : undefined
        }`}
      >
        <Image src={orderImg} with={20} height={20} alt="Account Image" />
        <p>Manage Order</p>
      </Link>
      <Link
        href="/account/billings"
        className={`${classes.navLink} ${
          isBillingPage ? classes.activeLink : undefined
        }`}
      >
        <Image src={creditcardImg} with={20} height={20} alt="Account Image" />
        <p>Billing Infomation</p>
      </Link>
      <Link
        href="/account/addresses"
        className={`${classes.navLink} ${
          isAddressPage ? classes.activeLink : undefined
        }`}
      >
        <Image src={locationImg} with={20} height={20} alt="Account Image" />
        <p>Address</p>
      </Link>
    </div>
  );
}
