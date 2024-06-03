import { redirect } from "next/navigation";

import ListBooks from "@/components/book/list-books";
import CategoryCatalog from "@/components/category/category-catalog";
import SortBy from "@/components/common/sort-by";
import { getAllActiveCategoriesAction } from "@/actions/category-actions.js";
import { getBookByCategoryUrlAction } from "@/actions/book-actions";

import classes from "@/styles/layout/category-page.module.css";
import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";

export default async function CategoryPage({ params }) {
  const categoryName = params.categoryName;

  const allCategories = await getAllActiveCategoriesAction();

  const category = allCategories.find(
    (category) => category.url.replace("/", "") === categoryName
  );
  if (!category) redirect("/all-books");

  const booksByCategoryUrl = await getBookByCategoryUrlAction(categoryName);

  return (
    <div className={LAYOUT_PRIMARY + classes.categoryPage}>
      <CategoryCatalog allCategories={allCategories} />
      <div className={classes.main}>
        <SortBy />
        <ListBooks listBooks={booksByCategoryUrl} />
      </div>
    </div>
  );
}
