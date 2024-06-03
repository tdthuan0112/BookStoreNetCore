import { notFound } from "next/navigation";

import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import { BOOK_API } from "@/api";

import BookDetail from "@/components/book/book-detail";
import CustomerReviews from "@/components/customer-reviews/customer-review";
import { getBookDetailByUrlAction } from "@/actions/book-actions";

import classes from "@/styles/layout/book-detail-page.module.css";

export default async function BookDetailPage({ params }) {
  const bookUrl = params["book-detail-name"];

  let book = await getBookDetailByUrlAction(bookUrl);

  //TODO HANDLE NOT FOUND BOOK
  // if (!book) notFound();
  return (
    <div className={LAYOUT_PRIMARY + classes.bookDetailPage}>
      <BookDetail book={book} />
      <CustomerReviews bookId={book.bookId} />
    </div>
  );
}
