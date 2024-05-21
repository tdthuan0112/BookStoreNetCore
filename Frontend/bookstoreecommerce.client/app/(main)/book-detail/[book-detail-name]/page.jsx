import { notFound } from "next/navigation";

import { DUMMY_BOOKS } from "@/lib/constant/constantData";
import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";

import BookDetail from "@/components/book/book-detail";
import CustomerReviews from "@/components/customer-reviews/customer-review";

import classes from "@/styles/layout/book-detail-page.module.css";
import { BOOK_API } from "@/api";

export default async function BookDetailPage({ params }) {
  const bookUrl = params["book-detail-name"];

  let book = await BOOK_API.getBookDetailByUrl(bookUrl);
  console.log(book);

  //TODO HANDLE NOT FOUND BOOK
  // if (!book) notFound();
  return (
    <div className={LAYOUT_PRIMARY + classes.bookDetailPage}>
      <BookDetail book={book} />
      <CustomerReviews bookId={book.bookId} />
    </div>
  );
}
