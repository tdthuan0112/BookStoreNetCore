// "use client";

import Image from "next/image";

import OrderInfo from "@/components/order/order-result-info";

import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import { navigateAllBooks } from "@/lib/helper/navigate-helper";

import orderSuccessImg from "@/assets/img/order-success.png";
import classes from "@/styles/layout/order-success.module.css";
import { getOrderDetailByIdAction } from "@/actions/order-actions";

export default async function OrderSuccessDetailPage({ params }) {
  const orderId = params.orderId;
  const orderDetail = await getOrderDetailByIdAction(orderId);
  return (
    <div className={LAYOUT_PRIMARY + classes.orderSuccessPage}>
      <Image
        src={orderSuccessImg}
        alt="Order Success Image"
        width={500}
        height={500}
      />
      <div className={classes.orderInfo}>
        <OrderInfo orderDetailInfo={orderDetail} />
        <form action={navigateAllBooks}>
          <button className={BTN_PRIMARY}>Continue shopping</button>
        </form>
      </div>
    </div>
  );
}
