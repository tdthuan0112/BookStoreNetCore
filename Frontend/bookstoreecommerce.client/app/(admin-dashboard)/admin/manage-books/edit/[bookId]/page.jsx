import { getBookDetailByBookId } from "@/actions/book-actions";
import BookDetailForm from "@/components/book/book-detail-form";
import classes from "@/styles/layout/admin-edit-book-detail-page.module.css";

export default async function AdminEditBookDetailPage({ params }) {
  const bookId = params.bookId;
  const book = await getBookDetailByBookId(bookId);
  console.log(book);
  return (
    <div>
      <h3>Edit Book</h3>
      <BookDetailForm book={book} mode="edit" />
    </div>
  );
}
