import classes from "@/styles/common/product-ordered-item.module.css";
import Image from "next/image";

export default function ProductOrderedItem({ cartItem }) {
  return (
    <>
      <div key={cartItem.bookId} className={classes.cartItem}>
        <Image
          src={cartItem.imageUrl}
          width={75}
          height={100}
          alt="book image"
        />
        <div className={classes.bookContent}>
          <p className={classes.title}>{cartItem.title}</p>
          <p className={classes.author}>by {cartItem.author}</p>
          <p className={classes.price}>$ {cartItem.totalPrice}</p>
          <p>
            <strong>Quantity: {cartItem.quantity}</strong>
          </p>
        </div>
      </div>
      <hr className={classes.hrStyle} />
    </>
  );
}
