"use server";

import { BOOK_API } from "@/api";

export async function getAllBooksAction() {
  return await BOOK_API.getAllBook();
}

export async function getBookDetailByBookId(bookId) {
  return await BOOK_API.getBookDetailByBookId(bookId);
}
