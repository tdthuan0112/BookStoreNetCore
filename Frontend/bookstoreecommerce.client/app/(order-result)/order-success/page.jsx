"use client";

import Image from "next/image";

import OrderInfo from "@/components/order-result/order-info";

import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import orderSuccessImg from "@/assets/img/order-success.png";

import classes from "@/styles/layout/order-success.module.css";
import { navigateAllBooks } from "@/lib/helper/navigate-helper";

export default function OrderSuccessPage() {
  function handleContinueShopping() {
    navigateAllBooks();
  }
  return (
    <div className={LAYOUT_PRIMARY + classes.orderSuccessPage}>
      <Image
        src={orderSuccessImg}
        alt="Order Success Image"
        width={500}
        height={500}
      />
      <div className={classes.orderInfo}>
        <OrderInfo />
        <button onClick={handleContinueShopping} className={BTN_PRIMARY}>
          Continue shopping
        </button>
      </div>
    </div>
  );
}
