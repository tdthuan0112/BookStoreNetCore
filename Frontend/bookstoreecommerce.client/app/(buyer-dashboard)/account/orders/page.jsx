import { getAllUserOrdersAction } from "@/actions/order-actions";
import {
  getCssOrderStatus,
  transfomDateValue,
} from "@/lib/helper/common-helper";
import classes from "@/styles/layout/account-manage-order-page.module.css";
import Link from "next/link";

export default async function AccountManageOrderPage() {
  const orders = await getAllUserOrdersAction();

  return (
    <div>
      <h2>Manage Order</h2>
      <div className={classes.listOrders}>
        <div className={`${classes.templateOrder} ${classes.header}`}>
          <p>Order Id</p>
          <p>Date of purchase</p>
          <p>Books</p>
          <p>Total</p>
          <p>Status</p>
        </div>
        <hr className={classes.hrLine} />
        {orders.map((order) => (
          <>
            <div className={classes.templateOrder} key={order.id}>
              <Link
                href={`/order-detail/${order.orderId}`}
                className={classes.orderItemLink}
              >
                {Math.abs(order.orderNumber)}
              </Link>
              <p>{transfomDateValue(order.dateCreated)}</p>
              <p>{order.title}</p>
              <p>$ {order.totalPrice}</p>
              <p className={getCssOrderStatus(order.orderStatus)}>
                {order.orderStatus}
              </p>
            </div>
            <hr className={classes.hrLine} />
          </>
        ))}
      </div>
    </div>
  );
}
