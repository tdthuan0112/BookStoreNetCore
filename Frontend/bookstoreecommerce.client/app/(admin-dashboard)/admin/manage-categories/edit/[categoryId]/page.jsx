import { getCategoryDetailByIdAction } from "@/actions/category-actions";
import AdminCategoryForm from "@/components/category/admin-category-form.jsx";

export default async function AdminEditCategoryDetailPage({ params }) {
  const categoryId = params.categoryId;
  const category = await getCategoryDetailByIdAction(categoryId);
  return (
    <div>
      <h3>Edit category</h3>
      <AdminCategoryForm category={category} mode="edit" />
    </div>
  );
}
