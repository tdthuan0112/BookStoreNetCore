"use client";
import Image from "next/image";
import Link from "next/link";
import { useTransition } from "react";

import ratingStarIcon from "@/assets/img/rating-star-full.png";

import classes from "@/styles/common/list-books.module.css";
import { CART_API } from "@/api";

export default function ListBooks({ listBooks }) {
  const [isPending, startTransition] = useTransition();

  function handleAddToCart(bookId) {
    startTransition(async () => {
      await CART_API.addToCart(bookId);
    });
  }

  function buildBookUrl(url) {
    return `/book-detail/${url}`;
  }

  return (
    <div className={classes.listBooks}>
      {listBooks.map((book) => (
        <div className={classes.bookItem} key={book.bookId}>
          <Link href={buildBookUrl(book.url)}>
            <Image src={book.imageUrl} alt="book" width={130} height={175} />
          </Link>
          <div className={classes.bookContent}>
            <div className={classes.contentHeader}>
              <Link className={classes.title} href={buildBookUrl(book.url)}>
                <h3 book-id={book.bookId}>{book.title}</h3>
              </Link>
              <div className={classes.rating}>
                <Image src={ratingStarIcon} width={24} alt="Rating" />
                <p>{book.rating}</p>
              </div>
            </div>
            <p className={classes.author}>{book.author}</p>
            <p className={classes.originalPrice}>${book.originalPrice}</p>
            <p className={classes.description}>{book.description}</p>
            <button
              className={classes.addToCartBtn}
              onClick={() => handleAddToCart(book.bookId)}
            >
              Add to Cart
            </button>
          </div>
        </div>
      ))}
    </div>
  );
}
