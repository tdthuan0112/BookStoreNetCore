import { GetAllOrdersAction } from "@/actions/order-actions";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import {
  getCssOrderStatus,
  transfomDateTimeValue,
} from "@/lib/helper/common-helper";
import { navigateAdminOrderDetail } from "@/lib/helper/navigate-helper";
import classes from "@/styles/layout/admin-manage-orders-page.module.css";

export default async function AdminManageOrdersPage() {
  const allOrders = await GetAllOrdersAction();
  console.log(allOrders);
  return (
    <div>
      <h3>Mangage Orders</h3>
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
              <td>{transfomDateTimeValue(order.dateCreated)}</td>
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
