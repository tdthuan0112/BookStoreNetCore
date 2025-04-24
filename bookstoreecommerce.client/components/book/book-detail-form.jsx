"use client";

import Image from "next/image";
import { useState } from "react";

import CategorySelector from "@/components/category/category-selector";
import CustomIcon from "@/components/common/custom-icon.jsx";
import defaultImageSquare from "@/assets/img/image-square.png";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName.js";

import classes from "@/styles/common/book-detail-form.module.css";
import {
  addNewBookAction,
  deleteBookAction,
  updateBookDetailAction,
} from "@/actions/book-actions";

export default function BookDetailForm({ book, mode, allCategories }) {
  const isEditMode = mode === "edit";
  const isAddNewBookMode = mode === "addNewBook";
  return (
    <>
      {isEditMode && (
        <EditBookDetailForm book={book} allCategories={allCategories} />
      )}
      {isAddNewBookMode && (
        <AddNewBookDetailForm allCategories={allCategories} />
      )}
    </>
  );
}

function EditBookDetailForm({ book, allCategories }) {
  const [isActiveBook, setIsActiveBook] = useState(book.isActive);
  function toggleIsActiveBook() {
    setIsActiveBook((preValue) => !preValue);
  }

  return (
    <form className={classes.mainContainer}>
      <Image src={book.imageUrl} width={200} height={280} alt={book.title} />
      <div className={classes.contentContainer}>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>
              Book Title <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="hidden" name="bookId" defaultValue={book.bookId} />
            <input type="text" defaultValue={book.title} name="title" />
          </div>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>
              Original Price{" "}
              <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input
              type="text"
              defaultValue={book.originalPrice}
              name="originalPrice"
            />
          </div>
        </div>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>
              Author <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" defaultValue={book.author} name="author" />
          </div>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>
              Discount Price
              <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input
              type="text"
              defaultValue={book.discountPrice}
              name="discountPrice"
            />
          </div>
        </div>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>
              Book Url <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" defaultValue={book.url} name="url" />
          </div>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>Discount Type</p>
            <div className={classes.discountTypeInput}>
              <p>Percent</p>
              <input
                type="radio"
                name="discountType"
                defaultChecked={book.isDiscountPercent}
                value="percent"
              ></input>
              <p>Price</p>
              <input
                type="radio"
                name="discountType"
                defaultChecked={!book.isDiscountPercent}
                value="price"
              ></input>
            </div>
          </div>
        </div>
        <div className={classes.singleProperty}>
          <p className={classes.propertyTitle}>
            Image Url <strong className={classes.requiredProperty}>*</strong>
          </p>
          <input type="text" defaultValue={book.imageUrl} name="imageUrl" />
        </div>
        <div className={classes.singleProperty}>
          <p className={classes.propertyTitle}>
            Category <strong className={classes.requiredProperty}>*</strong>
          </p>
          <CategorySelector
            bookCategory={book.listCategories}
            allCategories={allCategories}
          />
        </div>
        <div className={classes.singleProperty}>
          <p className={classes.propertyTitle}>
            Quantity In Stock{" "}
            <strong className={classes.requiredProperty}>*</strong>
          </p>
          <input
            type="number"
            defaultValue={book.quantityInStock}
            name="quantityInStock"
          />
        </div>
        <div className={classes.singleProperty}>
          <p className={classes.propertyTitle}>
            Description <strong className={classes.requiredProperty}>*</strong>
          </p>
          <textarea
            defaultValue={book.description}
            contentEditable
            name="description"
          />
        </div>
        <div className={classes.activeCheckbox}>
          <p className={classes.propertyTitle}>
            Active: <strong className={classes.requiredProperty}></strong>
          </p>
          <div onClick={toggleIsActiveBook} className={classes.checkboxIcon}>
            <CustomIcon
              icon={
                isActiveBook
                  ? "fluent:checkbox-checked-20-filled"
                  : "fluent:checkbox-unchecked-20-filled"
              }
              width={24}
              height={24}
            />
            <input
              type="hidden"
              name="isActive"
              defaultValue={isActiveBook}
            ></input>
          </div>
        </div>
        <div className={classes.buttonBlock}>
          <button
            type="submit"
            formAction={deleteBookAction}
            className={classes.btnDeleteBook}
          >
            DELETE BOOK
          </button>
          <button
            type="submit"
            formAction={updateBookDetailAction}
            className={BTN_PRIMARY + classes.btnSaveBook}
          >
            SAVE
          </button>
        </div>
      </div>
    </form>
  );
}

function AddNewBookDetailForm({ allCategories }) {
  const [isActiveBook, setIsActiveBook] = useState(true);
  const [imageUrl, setImageUrl] = useState("");
  function toggleIsActiveBook() {
    setIsActiveBook((preValue) => !preValue);
  }

  return (
    <form className={classes.mainContainer}>
      <Image
        src={defaultImageSquare}
        width={200}
        height={200}
        alt="Default Image Square"
      />
      <div className={classes.contentContainer}>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>
              Book Title <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" placeholder="Book Title" name="title" />
          </div>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>
              Original Price{" "}
              <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input
              type="text"
              placeholder="Original Price"
              name="originalPrice"
            />
          </div>
        </div>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>
              Author <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" placeholder="Author" name="author" />
          </div>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>
              Discount Price
              <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input
              type="text"
              placeholder="Discount Price"
              name="discountPrice"
            />
          </div>
        </div>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>
              Book Url <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" placeholder="http:// ..." name="url" />
          </div>
          <div className={classes.singleProperty}>
            <p className={classes.propertyTitle}>Discount Type</p>
            <div className={classes.discountTypeInput}>
              <p>Percent</p>
              <input
                type="radio"
                name="discountType"
                value="percent"
                defaultChecked
              ></input>
              <p>Price</p>
              <input type="radio" name="discountType" value="price"></input>
            </div>
          </div>
        </div>
        <div className={classes.singleProperty}>
          <p className={classes.propertyTitle}>
            Image Url <strong className={classes.requiredProperty}>*</strong>
          </p>
          <input type="text" placeholder="http:// ..." name="imageUrl" />
        </div>
        <div className={classes.singleProperty}>
          <p className={classes.propertyTitle}>
            Category <strong className={classes.requiredProperty}>*</strong>
          </p>
          <CategorySelector allCategories={allCategories} />
        </div>
        <div className={classes.singleProperty}>
          <p className={classes.propertyTitle}>
            Quantity In Stock{" "}
            <strong className={classes.requiredProperty}>*</strong>
          </p>
          <input type="number" name="quantityInStock" />
        </div>
        <div className={classes.singleProperty}>
          <p className={classes.propertyTitle}>
            Description <strong className={classes.requiredProperty}>*</strong>
          </p>
          <textarea placeholder="Description" name="description" />
        </div>
        <div className={classes.activeCheckbox}>
          <p className={classes.propertyTitle}>
            Active: <strong className={classes.requiredProperty}></strong>
          </p>
          <div onClick={toggleIsActiveBook} className={classes.checkboxIcon}>
            <CustomIcon
              icon={
                isActiveBook
                  ? "fluent:checkbox-checked-20-filled"
                  : "fluent:checkbox-unchecked-20-filled"
              }
              width={24}
              height={24}
            />
            <input type="hidden" defaultValue={isActiveBook}></input>
          </div>
        </div>
        <div className={classes.buttonBlock}>
          <button
            type="submit"
            formAction={addNewBookAction}
            className={BTN_PRIMARY + classes.btnSaveBook}
          >
            ADD NEW BOOK
          </button>
        </div>
      </div>
    </form>
  );
}
