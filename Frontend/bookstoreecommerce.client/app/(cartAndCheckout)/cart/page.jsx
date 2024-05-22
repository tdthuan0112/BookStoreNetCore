import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import CartItem from "@/components/cartAndCheckout/cart-item";

import classes from "@/styles/layout/cart-page.module.css";
import { navigateCheckout } from "@/lib/helper/navigate-helper";
import { getCartAction } from "@/actions/cart-actions";

export default async function CartPage() {
  let cart = await getCartAction();

  // function handleCheckout() {
  //   navigateCheckout();
  // }

  return (
    <div className={LAYOUT_PRIMARY + classes.cartPage}>
      <h2>Shopping Cart</h2>
      <div className={classes.generalHeader}>
        <p className={classes.productHeader}>Product</p>
        <p>Unit Price</p>
        <p>Quantity</p>
        <p>Total Price</p>
        <p>Action</p>
      </div>
      <div className={classes.listCartItems}>
        {cart.cartItems.map((cartitem) => (
          <CartItem key={cartitem.bookId} cartItem={cartitem} />
        ))}
      </div>
      <div className={classes.summaryBlock}>
        <h2>
          Total:{" "}
          <span className={classes.totalPrice}>{cart.totalPriceCart} $</span>
        </h2>
        <button className={BTN_PRIMARY}>Check Out</button>
      </div>
    </div>
  );
}
