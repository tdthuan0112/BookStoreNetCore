import Image from "next/image";

import Counter from "@/components/common/counter";
import classes from "@/styles/common/cart-item.module.css";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";

export default function CartItem({ cartItem }) {
  const unitPrice = cartItem.originalPrice;
  let quantity = 2;
  const totalPrice = cartItem.originalPrice * quantity;
  return (
    <>
      <div className={classes.cartItem}>
        <div className={classes.imageAndTitle}>
          <Image
            src={cartItem.imageUrl}
            height={100}
            width={75}
            alt="Book Image"
          />
          <div>
            <h3 className={classes.title}>{cartItem.title}</h3>
            <p className={classes.author}>by {cartItem.author}</p>
          </div>
        </div>
        <div>{unitPrice}</div>
        <div>
          <Counter max={cartItem.quantity} intialValue={cartItem.quantity} />
        </div>
        <div>{totalPrice}</div>
        <div>
          <button className={BTN_PRIMARY + classes.deleteBtn}>Delete</button>
        </div>
      </div>
      <hr className={classes.hr} />
    </>
  );
}
