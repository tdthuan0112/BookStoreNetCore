"use client";

import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import { DUMMY_BOOKS } from "@/lib/constant/constantData";
import CartItem from "@/components/cartAndCheckout/cart-item";

import classes from "@/styles/layout/cart-page.module.css";
import { navigateCheckout } from "@/lib/action/actions";

export default function CartPage() {
  function handleCheckout() {
    navigateCheckout();
  }

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
        {DUMMY_BOOKS.map((book) => (
          <CartItem key={book.bookId} cartItem={book} />
        ))}
      </div>
      <div className={classes.summaryBlock}>
        <h2>
          Total: <span className={classes.totalPrice}>16.99 $</span>
        </h2>
        <button onClick={handleCheckout} className={BTN_PRIMARY}>
          Check Out
        </button>
      </div>
    </div>
  );
}
