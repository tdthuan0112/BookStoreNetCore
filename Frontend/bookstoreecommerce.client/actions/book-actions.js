"use server";

import { BOOK_API } from "@/api";
import { getAdminUserAction } from "./user-actions";

export async function getAllBooksAction() {
  return await BOOK_API.getAllBook();
}

export async function getBookDetailByBookId(bookId) {
  return await BOOK_API.getBookDetailByBookId(bookId);
}

export async function deleteBookAction(formData) {
  const bookId = formData.get("bookId");
  return await BOOK_API.deleteBook(bookId);
}

export async function updateBookDetailAction(formData) {
  const data = Object.fromEntries(formData);
  const admin = await getAdminUserAction();
  const modifiedBy = admin.userId;
  let payload = {
    bookId: data.bookId,
    title: data.title,
    author: data.author,
    description: data.description,
    url: data.url,
    imageUrl: data.imageUrl,
    quantityInStock: parseInt(data.quantityInStock),
    originalPrice: parseFloat(data.originalPrice),
    discountPrice: parseFloat(data.discountPrice),
    isDiscountPercent: data.discountType === "percent",
    isActive: data.isActive === "true",
    modifiedBy: modifiedBy,
    listCategoryIds: data.listCategoryIds.split(","),
  };
  console.log(payload);
  return await BOOK_API.updateBookDetail(payload);
}

export async function addNewBookAction(formData) {
  const data = Object.fromEntries(formData);
  const admin = await getAdminUserAction();
  const createdBy = admin.userId;
  let payload = {
    title: data.title,
    author: data.author,
    description: data.description,
    url: data.url,
    imageUrl: data.imageUrl,
    quantityInStock: parseInt(data.quantityInStock),
    originalPrice: parseFloat(data.originalPrice),
    discountPrice: parseFloat(data.discountPrice),
    isDiscountPercent: data.discountType === "percent",
    isActive: data.isActive === "true",
    createdBy: createdBy,
    listCategoryIds: data.listCategoryIds.split(","),
  };
  console.log(payload);
  return await BOOK_API.addNewBook(payload);
}
