import { redirect } from "next/navigation";

export default function OrderSuccessPage() {
  redirect("/all-books");
}
