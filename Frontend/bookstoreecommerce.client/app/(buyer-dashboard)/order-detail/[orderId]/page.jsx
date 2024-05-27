import { getOrderDetailByIdAction } from "@/actions/order-actions";
import OrderDetail from "@/components/order/order-detail";
import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";

export default async function OrderDetailPage({ params }) {
  const orderId = params.orderId;
  const order = await getOrderDetailByIdAction(orderId);
  return (
    <div className={LAYOUT_PRIMARY} style={{ paddingTop: "20px" }}>
      <OrderDetail order={order} />;
    </div>
  );
}
