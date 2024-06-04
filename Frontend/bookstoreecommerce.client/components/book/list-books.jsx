//Components
import BookItemCategory from "./book-item-category";
//CSS
import classes from "@/styles/common/list-books.module.css";

export default function ListBooks({ listBooks }) {
  return (
    <div className={classes.listBooks}>
      {listBooks.map((book) => (
        <BookItemCategory key={book.bookId} book={book} />
      ))}
    </div>
  );
}
