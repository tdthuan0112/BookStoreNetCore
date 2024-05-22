import classes from "@/styles/common/list-books.module.css";
import BookItemCategory from "./book-item-category";

export default function ListBooks({ listBooks }) {
  return (
    <div className={classes.listBooks}>
      {listBooks.map((book) => (
        <BookItemCategory book={book} />
      ))}
    </div>
  );
}
