"use client";

import CheckoutInfo from "@/components/cartAndCheckout/checkout-info";
import ProductOrdered from "@/components/cartAndCheckout/product-ordered";
import PaymentMethod from "@/components/cartAndCheckout/payment-method";
import ShippingMethod from "@/components/cartAndCheckout/shipping-method";

import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/checkout-page.module.css";
import { navigateOrderSuccess } from "@/lib/action/actions";

export default function CheckoutPage() {
  function handeClickPlaceOrder() {
    navigateOrderSuccess();
  }
  return (
    <div className={LAYOUT_PRIMARY + classes.checkoutPage}>
      <div className={classes.leftColumn}>
        <CheckoutInfo />
        <ShippingMethod />
        <PaymentMethod />
        <button onClick={handeClickPlaceOrder} className={BTN_PRIMARY}>
          PLACE ORDER
        </button>
      </div>
      <div>
        <ProductOrdered />
      </div>
    </div>
  );
}
