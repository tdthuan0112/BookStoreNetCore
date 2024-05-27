"use client";

import {
  addNewCategoryAction,
  deleteCategoryAction,
  updateCategoryAction,
} from "@/actions/category-actions";
import CustomIcon from "@/components/common/custom-icon.jsx";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/common/admin-category-form.module.css";
import { useState } from "react";

export default function AdminCategoryForm({ category, mode }) {
  const isEditMode = mode === "edit";
  const isAddNewCateMode = mode === "addNewCate";
  return (
    <>
      {isEditMode && <EditCategoryDetailForm category={category} />}
      {isAddNewCateMode && <AddNewCategoryForm />}
    </>
  );
}

function EditCategoryDetailForm({ category }) {
  const [isActiveCate, setIsActiveCate] = useState(category.isActive);
  function toggleIsActiveCate() {
    setIsActiveCate((preValue) => !preValue);
  }
  return (
    <form className={classes.adminCategoryForm}>
      <input
        type="hidden"
        name="categoryId"
        defaultValue={category.categoryId}
      />
      <div className={classes.singleProperty}>
        <p htmlFor="name">
          Category Name <strong>*</strong>
        </p>
        <input type="text" name="name" defaultValue={category.name} />
      </div>
      <div className={classes.singleProperty}>
        <p htmlFor="name">
          Url <strong>*</strong>
        </p>
        <input type="text" name="url" defaultValue={category.url} />
      </div>
      <div className={classes.singleProperty}>
        <p htmlFor="name">
          Quantity <strong>*</strong>
        </p>
        <input type="number" name="quantity" defaultValue={category.quantity} />
      </div>
      <div className={classes.activeCheckbox}>
        <p>
          Active: <strong className={classes.requiredProperty}></strong>
        </p>
        <div onClick={toggleIsActiveCate} className={classes.checkboxIcon}>
          <CustomIcon
            icon={
              isActiveCate
                ? "fluent:checkbox-checked-20-filled"
                : "fluent:checkbox-unchecked-20-filled"
            }
            width={24}
            height={24}
          />
          <input
            type="hidden"
            name="isActive"
            defaultValue={isActiveCate}
          ></input>
        </div>
      </div>
      <div className={classes.buttonBlock}>
        <button
          type="submit"
          formAction={deleteCategoryAction}
          className={classes.btnDeleteCategory}
        >
          DELETE CATEGORY
        </button>
        <button
          type="submit"
          formAction={updateCategoryAction}
          className={BTN_PRIMARY + classes.btnSaveCategory}
        >
          SAVE
        </button>
      </div>
    </form>
  );
}

function AddNewCategoryForm() {
  const [isActiveCate, setIsActiveCate] = useState(true);
  function toggleIsActiveCate() {
    setIsActiveCate((preValue) => !preValue);
  }
  return (
    <form className={classes.adminCategoryForm}>
      <div className={classes.singleProperty}>
        <p htmlFor="name">
          Category Name <strong>*</strong>
        </p>
        <input type="text" name="name" />
      </div>
      <div className={classes.singleProperty}>
        <p htmlFor="name">
          Url <strong>*</strong>
        </p>
        <input type="text" name="url" />
      </div>
      <div className={classes.singleProperty}>
        <p htmlFor="name">
          Quantity <strong>*</strong>
        </p>
        <input type="number" name="quantity" defaultValue={0} />
      </div>
      <div className={classes.activeCheckbox}>
        <p>
          Active: <strong className={classes.requiredProperty}></strong>
        </p>
        <div onClick={toggleIsActiveCate} className={classes.checkboxIcon}>
          <CustomIcon
            icon={
              isActiveCate
                ? "fluent:checkbox-checked-20-filled"
                : "fluent:checkbox-unchecked-20-filled"
            }
            width={24}
            height={24}
          />
          <input type="hidden" name="isActive" value={isActiveCate}></input>
        </div>
      </div>
      <div className={classes.buttonBlock}>
        <button
          type="submit"
          formAction={addNewCategoryAction}
          className={BTN_PRIMARY + classes.btnSaveCategory}
        >
          ADD NEW CATEGORY
        </button>
      </div>
    </form>
  );
}
