"use client";
import Image from "next/image";

import Counter from "@/components/common/counter";
import classes from "@/styles/common/cart-item.module.css";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import { deleteCartAction, updateCartAction } from "@/actions/cart-actions";
import { useFormStatus } from "react-dom";
import Link from "next/link";

export default function CartItem({ cartItem }) {
  const { pending } = useFormStatus();
  const isHaveDiscount = cartItem.discountPrice > 0;
  function onHandleUpdateCart(quantity) {
    updateCartAction(cartItem.bookId, quantity);
  }
  return (
    <form action={() => deleteCartAction(cartItem.bookId)}>
      <div className={classes.cartItem}>
        <div className={classes.imageAndTitle}>
          <Link href={`/book-detail/${cartItem.url}`}>
            <Image
              src={cartItem.imageUrl}
              height={100}
              width={75}
              alt="Book Image"
            />
          </Link>
          <div book-id={cartItem.bookId}>
            <h3 className={classes.title}>{cartItem.title}</h3>
            <p className={classes.author}>by {cartItem.author}</p>
          </div>
        </div>
        <div>
          <p>{cartItem.finalPrice}</p>
          {isHaveDiscount && (
            <p className={classes.originalPrice}>{cartItem.originalPrice}</p>
          )}
        </div>
        <div>
          <Counter
            name="quantity"
            max={cartItem.quantityInStock}
            type="submit"
            intialValue={cartItem.quantity}
            onHandleUpdateCart={onHandleUpdateCart}
          />
        </div>
        <div>{cartItem.totalPrice}</div>
        <div note="div-for-styling">
          <button
            className={BTN_PRIMARY + classes.deleteBtn}
            disabled={pending}
            type="submit"
          >
            {pending ? "Processing..." : "Delete"}
          </button>
        </div>
      </div>
      <hr className={classes.hr} />
    </form>
  );
}
