import { API } from "@/api/index";

export function getAllBook() {
  return API.get("/Book/GetAllBooks");
}
