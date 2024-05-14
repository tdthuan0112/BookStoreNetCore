import Image from "next/image";
import Link from "next/link";

import ratingStarIcon from "@/assets/img/rating-star-full.png";
import { DUMMY_BOOKS } from "@/lib/constant/constantData";

import classes from "@/styles/common/list-books.module.css";

export default function ListBooks() {
  //TODO
  function fetchListFilteredBooks() {}

  return (
    <div className={classes.listBooks}>
      {DUMMY_BOOKS.map((book) => (
        <div className={classes.bookItem}>
          <Link href={book.url}>
            <Image src={book.imageUrl} alt="book" width={130} height={175} />
          </Link>
          <div className={classes.bookContent}>
            <div className={classes.contentHeader}>
              <Link className={classes.title} href={book.url}>
                <h3>{book.title}</h3>
              </Link>
              <div className={classes.rating}>
                <Image src={ratingStarIcon} width={24} alt="Rating" />
                <p>{book.rating}</p>
              </div>
            </div>
            <p className={classes.author}>{book.author}</p>
            <p className={classes.originalPrice}>${book.originalPrice}</p>
            <p className={classes.description}>{book.description}</p>
            <button className={classes.addToCartBtn}>Add to Cart</button>
          </div>
        </div>
      ))}
    </div>
  );
}
