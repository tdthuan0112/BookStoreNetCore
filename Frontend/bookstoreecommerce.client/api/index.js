import BookApi from "@/api/book";
import CategoryApi from "./category";
import UserApi from "./user";
import CartApi from "./cart";

export const BOOK_API = new BookApi();
export const CATEGORY_API = new CategoryApi();
export const USER_API = new UserApi();
export const CART_API = new CartApi();
