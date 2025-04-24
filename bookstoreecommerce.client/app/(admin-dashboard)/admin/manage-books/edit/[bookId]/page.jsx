import { getBookDetailByBookId } from "@/actions/book-actions";
import { getAllCategoriesAction } from "@/actions/category-actions";
import BookDetailForm from "@/components/book/book-detail-form.jsx";
import classes from "@/styles/layout/admin-edit-book-detail-page.module.css";

export default async function AdminEditBookDetailPage({ params }) {
  const bookId = params.bookId;
  const book = await getBookDetailByBookId(bookId);
  console.log(book);
  const allCategories = await getAllCategoriesAction();
  return (
    <div>
      <h3>Edit Book</h3>
      <BookDetailForm book={book} mode="edit" allCategories={allCategories} />
    </div>
  );
}
