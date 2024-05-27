import { GetAllOrdersAction } from "@/actions/order-actions";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import {
  getCssOrderStatus,
  isNullOrUndefined,
  transformDateTimeValue,
} from "@/lib/helper/common-helper";
import { navigateAdminOrderDetail } from "@/lib/helper/navigate-helper";
import classes from "@/styles/layout/admin-manage-orders-page.module.css";

export default async function ManageOrdersPage({ searchParams }) {
  const userId = searchParams.userId;
  const orderId = searchParams.orderId;
  const allOrders = await GetAllOrdersAction(userId, orderId);
  return (
    <div>
      <h3>Mangage Orders {!isNullOrUndefined(userId)}</h3>
      <table className={classes.mainContainer}>
        <tbody>
          <tr>
            <th>Order ID</th>
            <th>Order Number</th>
            <th>User ID</th>
            <th>Purchase Date</th>
            <th>Total</th>
            <th>Status</th>
            <th>Action</th>
          </tr>
          {allOrders.map((order) => (
            <tr className={classes.orderItem} key={order.orderId}>
              <td>{order.orderId}</td>
              <td>{Math.abs(order.orderNumber)}</td>
              <td>{order.userId}</td>
              <td>{transformDateTimeValue(order.dateCreated)}</td>
              <td>$ {order.totalPrice}</td>
              <td className={getCssOrderStatus(order.orderStatus)}>
                {order.orderStatus}
              </td>
              <td>
                <form action={navigateAdminOrderDetail}>
                  <input type="hidden" name="orderId" value={order.orderId} />
                  <button
                    type="submit"
                    className={`${BTN_PRIMARY} ${classes.viewDetail}`}
                  >
                    View Detail
                  </button>
                </form>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
