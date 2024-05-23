import classes from "@/styles/common/product-ordered.module.css";

import ProductOrderedItem from "@/components/cartAndCheckout/product-ordered-item";

export default async function ProductOrdered({ cart }) {
  return (
    <div className={classes.productOrdered}>
      <h3>Review Your Order</h3>
      <div className={classes.listProductOrderedItem}>
        {cart.cartItems.map((cartItem) => (
          <ProductOrderedItem key={cartItem.bookId} cartItem={cartItem} />
        ))}
      </div>
      <div className={classes.subtotal}>
        <p>Subtotal</p>
        <p className={classes.price}>{cart.totalPriceCart} $</p>
      </div>
      <div className={classes.shippingFee}>
        <p>Shipping Fee</p>
        <p className={classes.price}>0.0 $</p>
      </div>
      <hr />
      <div className={classes.paymentTotal}>
        <p className={classes.paymentTotalText}>Payment Total:</p>
        <p className={classes.finalPrice}>{cart.totalPriceCart} $</p>
      </div>
    </div>
  );
}
