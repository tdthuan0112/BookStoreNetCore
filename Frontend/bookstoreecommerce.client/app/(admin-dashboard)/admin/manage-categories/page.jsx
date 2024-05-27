import Link from "next/link";

import { navigatedminEditCategoryPage } from "@/lib/helper/navigate-helper.js";
import { getAllCategoriesAction } from "@/actions/category-actions.js";
import { transformDateTimeValue } from "@/lib/helper/common-helper.js";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName.js";
import CustomIcon from "@/components/common/custom-icon.jsx";
import classes from "@/styles/layout/admin-manage-categories-page.module.css";

export default async function AdminManageCategoriesPage() {
  const listCategories = await getAllCategoriesAction();
  return (
    <div className={classes.adminManageCategoriesPage}>
      <div className={classes.headerBlock}>
        <h3>Manage Categories</h3>
        <Link
          className={BTN_PRIMARY + classes.btnAddNewCate}
          href="/admin/manage-categories/add-new-cate"
        >
          <CustomIcon icon="carbon:add-filled" />
          Add new Category
        </Link>
      </div>
      <table className={classes.mainContainer}>
        <tbody>
          <tr>
            <th>Category ID</th>
            <th>Category Name</th>
            <th>Url</th>
            <th>Quantity</th>
            <th>Date created</th>
            <th>Active</th>
            <th>Action</th>
          </tr>
          {listCategories.map((category) => (
            <tr key={category.categoryId} className={classes.cateItem}>
              <td>{category.categoryId}</td>
              <td>{category.name}</td>
              <td>{category.url}</td>
              <td>{category.quantity}</td>
              <td>{transformDateTimeValue(category.dateCreated)}</td>
              <td>
                <CustomIcon
                  icon={
                    category.isActive
                      ? "fluent:checkbox-checked-20-filled"
                      : "fluent:checkbox-unchecked-20-filled"
                  }
                  width={24}
                  height={24}
                />
              </td>
              <td>
                <form action={navigatedminEditCategoryPage}>
                  <input
                    type="hidden"
                    defaultValue={category.categoryId}
                    name="categoryId"
                  />
                  <button
                    type="submit"
                    className={BTN_PRIMARY + classes.buttonEdit}
                  >
                    Edit
                  </button>
                </form>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
