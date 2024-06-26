import BookApi from "@/api/book";
import CategoryApi from "@/api/category";
import UserApi from "@/api/user";
import CartApi from "@/api/cart";
import OrderApi from "@/api/order";
import AuthenticationApi from "@/api/authentication";
import LocationApi from "@/api/location";

export const BOOK_API = new BookApi();
export const CATEGORY_API = new CategoryApi();
export const USER_API = new UserApi();
export const CART_API = new CartApi();
export const ORDER_API = new OrderApi();
export const AUTHENTICATION_API = new AuthenticationApi();
export const LOCATION_API = new LocationApi();
