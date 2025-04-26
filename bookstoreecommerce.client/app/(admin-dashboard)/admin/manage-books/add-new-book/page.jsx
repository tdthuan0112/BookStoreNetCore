import { getAllCategoriesAction } from "@/actions/category-actions";
import BookDetailForm from "@/components/book/book-detail-form";

export default async function AddNewBookPage() {
  const allCategories = await getAllCategoriesAction();
  return (
    <div>
      <h3>Add new book</h3>
      <BookDetailForm mode="addNewBook" allCategories={allCategories} />;
    </div>
  );
}
