import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import {
  getCssOrderStatus,
  transformDateTimeValue,
} from "@/lib/helper/common-helper";
import Image from "next/image";
import Link from "next/link";

import classes from "@/styles/common/order-detail.module.css";

export default function OrderDetail({ order, isAdmin = false }) {
  return (
    <div className={classes.orderDetailPage}>
      <div className={classes.pageTitle}>
        <h2>Order details - #{order.orderNumber}</h2>
        <p>
          <strong>Order date</strong>:{" "}
          {transformDateTimeValue(order.dateCreated)}
        </p>
      </div>
      <div className={classes.mainInfo}>
        <ReceiverInfo order={order} />
        <OrderDetailInfo order={order} />
      </div>
      <div className={classes.listOrderItems}>
        <div className={`${classes.listOrderItemsTemplate} ${classes.header}`}>
          <p className={classes.bookImgTitle}>Book</p>
          <p>Price</p>
          <p>Quantity</p>
          <p>Subtotal</p>
          <p>Action</p>
        </div>
        <hr className={classes.hrLine} />
        <div className={classes.orderItems}>
          {order.listOrderItems.map((orderItem) => (
            <>
              <OrderItem orderItem={orderItem} key={orderItem.id} />
              <hr className={classes.hrLine} />
            </>
          ))}
        </div>
        <div className={classes.priceBlock}>
          <div className={classes.priceBlockText}>
            <p className={classes.total}>Subtotal</p>
            <p>Shipping fee</p>
            <p>Total</p>
          </div>
          <div className={classes.priceBlockValue}>
            <p>{order.totalPrice}</p>
            <p>Free</p>
            <p className={classes.totalPrice}>$ {order.totalPrice}</p>
          </div>
        </div>
      </div>
    </div>
  );
}

function ReceiverInfo({ order }) {
  return (
    <div className={classes.receiverInfo}>
      <h3 className={classes.infoTitle}>Receiver information</h3>
      <div className={classes.detailContent}>
        <p>
          <strong>Receiver</strong>: Thuan Tran
        </p>
        <p>
          <strong>Email</strong>: thuanmaildemo@gmail.com
        </p>
        <p>
          <strong>Address</strong>: 123 Highway 1k, Binh An Di An Binh Duong
        </p>
        <p>
          <strong>Phone</strong>: (+84) 123 456 789
        </p>
      </div>
    </div>
  );
}

function OrderDetailInfo({ order }) {
  return (
    <div className={classes.receiverInfo}>
      <h3 className={classes.infoTitle}>Order Detail</h3>
      <div className={classes.detailContent}>
        <p>
          <strong>Order Status</strong>:{" "}
          <span className={getCssOrderStatus(order.orderStatus)}>
            {order.orderStatus}
          </span>
        </p>
        <p></p>
        <p>
          <strong>Shipping method</strong>: Standard
        </p>
        <p>
          <strong>Payment method</strong>: Cash Payment On Delivery (Ship COD)
        </p>
        <p>
          <strong>User note</strong>: "NOTE HERE"
        </p>
      </div>
    </div>
  );
}

function OrderItem({ orderItem }) {
  const isHaveDiscount = orderItem.discountPrice > 0;
  return (
    <div className={classes.listOrderItemsTemplate}>
      <Link
        href={`/book-detail/${orderItem.url}`}
        className={classes.bookImgTitle}
      >
        <Image
          src={orderItem.imageUrl}
          width={40}
          height={60}
          alt={orderItem.title}
        />
        <div>
          <p className={classes.title}>{orderItem.title}</p>
          <p className={classes.author}> by {orderItem.author}</p>
        </div>
      </Link>

      <div>
        <p>{orderItem.finalPrice}</p>
        {isHaveDiscount && (
          <p className={classes.originalPrice}>{orderItem.originalPrice}</p>
        )}
      </div>
      <p>{orderItem.quantity}</p>
      <p>{orderItem.totalPrice}</p>
      <div>
        <Link
          href={`/book-detail/${orderItem.url}`}
          className={BTN_PRIMARY + classes.buyItAgain}
        >
          Buy it again
        </Link>
      </div>
    </div>
  );
}
