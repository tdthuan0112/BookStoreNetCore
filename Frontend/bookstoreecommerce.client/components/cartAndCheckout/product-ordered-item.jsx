import classes from "@/styles/common/product-ordered-item.module.css";
import Image from "next/image";

export default function ProductOrderedItem({ bookItem }) {
  return (
    <>
      <div key={bookItem.bookId} className={classes.bookItem}>
        <Image
          src={bookItem.imageUrl}
          width={75}
          height={100}
          alt="book image"
        />
        <div className={classes.bookContent}>
          <p className={classes.title}>{bookItem.title}</p>
          <p className={classes.author}>by {bookItem.author}</p>
          <p className={classes.price}>$ {bookItem.originalPrice}</p>
          <p>
            <strong>Quantity: 1</strong>
          </p>
        </div>
      </div>
      <hr className={classes.hrStyle} />
    </>
  );
}
