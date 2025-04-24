import Image from "next/image";
import Link from "next/link";

import infoOutLineImg from "@/assets/img/info-outline.png";

import classes from "@/styles/common/order-info.module.css";

export default function OrderInfo({ orderDetailInfo }) {
  return (
    <div className={classes.orderInfo}>
      <p className={classes.thankyouText}>
        Thank You For Your Purchase of BookStore
      </p>
      <p>Your Order Id:</p>
      <p className={classes.orderId}>#{orderDetailInfo.orderNumber}</p>
      <p>
        You can review with{" "}
        <Link
          className={classes.myOrderLink}
          href={`/order-detail/${orderDetailInfo.orderId}`}
        >
          My Order
        </Link>
      </p>
      <div className={classes.helperBlock}>
        <Image
          src={infoOutLineImg}
          width={32}
          height={32}
          alt="Info Outline Image"
        />
        <p>
          To help process orders faster, BookStore will not call you to confirm
          orders.
        </p>
      </div>
    </div>
  );
}
