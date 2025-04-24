import Link from "next/link";
import Image from "next/image";

import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";

import CartItem from "@/components/cartAndCheckout/cart-item";
import classes from "@/styles/layout/cart-page.module.css";
import { getCartAction } from "@/actions/cart-actions";
import {
  isArrayHasAnyElements,
  isNullOrUndefined,
} from "@/lib/helper/common-helper";
import emptyCartImg from "@/assets/img/emptyCart.png";

export default async function CartPage() {
  let cart = await getCartAction();
  let contentCart;
  const isHaveCart =
    !isNullOrUndefined(cart) && isArrayHasAnyElements(cart.cartItems);
  if (isHaveCart) {
    contentCart = (
      <div className={classes.listCartItems}>
        {cart.cartItems.map((cartitem) => (
          <CartItem key={cartitem.bookId} cartItem={cartitem} />
        ))}
      </div>
    );
  } else {
    contentCart = (
      <div className={classes.cartEmpty}>
        <p className={classes.emptyText}>Your cart is empty</p>
        <Image src={emptyCartImg} width={200} alt="Empty cart imgage" />
        <Link
          href="/all-books"
          className={BTN_PRIMARY + classes.clickToPurchase}
        >
          Click here to purchase
        </Link>
      </div>
    );
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
      {contentCart}
      <div className={classes.summaryBlock}>
        <h2>
          Total:{" "}
          <span className={classes.totalPrice}>{cart.totalPriceCart} $</span>
        </h2>
        <Link
          href={isHaveCart ? "/checkout" : "/cart"}
          className={`${BTN_PRIMARY} ${
            !isHaveCart ? classes.disableCheckout : ""
          }`}
        >
          Check Out
        </Link>
      </div>
    </div>
  );
}
