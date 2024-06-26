import { getOrderDetailByIdAction } from "@/actions/order-actions";
import OrderDetail from "@/components/order/order-detail";

export default async function AdminOrderDetailPage({ params }) {
  const orderId = params.orderId;
  const order = await getOrderDetailByIdAction(orderId);
  return <OrderDetail order={order} isAdmin={true} />;
}
