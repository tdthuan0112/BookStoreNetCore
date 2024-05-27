import { getAllCategoriesAction } from "@/actions/category-actions";
import BookDetailForm from "@/components/book/book-detail-form";

export default async function AddNewBookPage() {
  const allCategories = await getAllCategoriesAction();
  console.log(allCategories);
  return (
    <div>
      <h3>Add new book</h3>
      <BookDetailForm mode="addNewBook" allCategories={allCategories} />;
    </div>
  );
}
