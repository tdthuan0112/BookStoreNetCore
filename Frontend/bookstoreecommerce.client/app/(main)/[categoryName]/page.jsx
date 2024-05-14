import { redirect } from "next/navigation";

import ListBooks from "@/components/book/list-books";
import CategoryCatalog from "@/components/category/category-catalog";
import SortBy from "@/components/common/sort-by";

import { DUMMY_CATEGORIES } from "@/lib/constant/constantData";

import classes from "@/styles/layout/category-page.module.css";
import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";

export default function CategoryPage({ params }) {
  const categoryName = params.categoryName;

  const category = DUMMY_CATEGORIES.find(
    (category) => category.url.replace("/", "") === categoryName
  );
  if (!category) redirect("/all-books");

  return (
    <div className={LAYOUT_PRIMARY + classes.categoryPage}>
      <CategoryCatalog />
      <div className={classes.main}>
        <SortBy />
        <ListBooks />
      </div>
    </div>
  );
}
