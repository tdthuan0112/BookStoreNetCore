import CheckoutInfo from "@/components/cartAndCheckout/checkout-info";
import ProductOrdered from "@/components/cartAndCheckout/product-ordered";
import PaymentMethod from "@/components/cartAndCheckout/payment-method";
import ShippingMethod from "@/components/cartAndCheckout/shipping-method";

import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/checkout-page.module.css";
import { submitOrderAction } from "@/actions/order-actions";
import { getCartAction } from "@/actions/cart-actions";

export default async function CheckoutPage() {
  const cart = await getCartAction("/cart");

  return (
    <form
      action={submitOrderAction}
      className={LAYOUT_PRIMARY + classes.checkoutPage}
    >
      <div className={classes.leftColumn}>
        <CheckoutInfo />
        <ShippingMethod />
        <PaymentMethod />
        <button className={BTN_PRIMARY}>PLACE ORDER</button>
      </div>
      <div>
        <ProductOrdered cart={cart} />
      </div>
    </form>
  );
}
