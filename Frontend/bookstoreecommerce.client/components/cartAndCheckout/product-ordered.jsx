import classes from "@/styles/common/product-ordered.module.css";

import ProductOrderedItem from "@/components/cartAndCheckout/product-ordered-item";
import { DUMMY_BOOKS } from "@/lib/constant/constantData";

export default function ProductOrdered() {
  return (
    <div className={classes.productOrdered}>
      <h3>Review Your Order</h3>
      <div className={classes.listProductOrderedItem}>
        {DUMMY_BOOKS.map((bookItem) => (
          <ProductOrderedItem key={bookItem.bookId} bookItem={bookItem} />
        ))}
      </div>
      <div className={classes.subtotal}>
        <p>Subtotal</p>
        <p className={classes.price}>120.0 $</p>
      </div>
      <div className={classes.shippingFee}>
        <p>Shipping Fee</p>
        <p className={classes.price}>0.0 $</p>
      </div>
      <hr />
      <div className={classes.paymentTotal}>
        <p className={classes.paymentTotalText}>Payment Total:</p>
        <p className={classes.finalPrice}>120.0 $</p>
      </div>
    </div>
  );
}
