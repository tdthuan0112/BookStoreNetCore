"use server";

import { BOOK_API } from "@/api";
import { getAdminUserAction } from "./user-actions";

export async function getAllBooksAction() {
  const response = await BOOK_API.getAllBook();
  return response.data;
}

export async function getBookByCategoryUrlAction(categoryUrl) {
  const response = await BOOK_API.getBookByCategoryUrl(categoryUrl);
  return response.data;
}

export async function getBookDetailByUrlAction(bookUrl) {
  const response = await BOOK_API.getBookDetailByUrl(bookUrl);
  return response.data;
}

export async function getBookDetailByBookId(bookId) {
  const response = await BOOK_API.getBookDetailByBookId(bookId);
  return response.data;
}

export async function deleteBookAction(formData) {
  const bookId = formData.get("bookId");
  const response = await BOOK_API.deleteBook(bookId);
  return response.data;
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
  const response = await BOOK_API.updateBookDetail(payload);
  return response.data;
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
  const response = await BOOK_API.addNewBook(payload);
  return response.data;
}
