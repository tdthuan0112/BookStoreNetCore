import Image from "next/image";

import ratingStarIcon from "@/assets/img/rating-star-full.png";

import classes from "@/styles/common/book-detail.module.css";
import QuantityCounter from "@/components/common/quantity-counter";

export default function BookDetail({ book }) {
  const finalPrice = book.originalPrice;
  console.log(book);
  return (
    <>
      <div className={classes.bookDetail}>
        <Image src={book.imageUrl} alt="book" width={240} height={330} />
        <div className={classes.bookContent}>
          <h1 className={classes.title}>{book.title}</h1>
          <p className={classes.author}>by {book.author}</p>
          <div className={classes.rating}>
            <p>{book.rating}</p>
            <Image src={ratingStarIcon} width={20} alt="Rating" />
            <p>
              {book.ratingCounter}{" "}
              {book.ratingCounter > 1 ? "ratings" : "rating"}
            </p>
          </div>
          <div className={classes.priceAndSale}>
            <p className={classes.originalPrice}>${book.originalPrice}</p>
            <p className={classes.finalPrice}>${finalPrice}</p>
            <p className={classes.salePercent}>Sale 20%</p>
          </div>
          <QuantityCounter max={book.quantityInStock} />
          <div className={classes.buttonBlock}>
            <button className={classes.addToCartBtn}>Add to Cart</button>
            <button className={classes.buyNowBtn}>Buy Now</button>
          </div>
        </div>
      </div>
      <h2 className={classes.descriptionTitle}>BOOK DESCRIPTION</h2>
      <div className={classes.descriptionBlock}>
        <p dangerouslySetInnerHTML={{ __html: book.description }}></p>
      </div>
    </>
  );
}
