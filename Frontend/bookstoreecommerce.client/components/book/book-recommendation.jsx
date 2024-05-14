import classes from "@/styles/common/book-recommendation.module.css";
import Image from "next/image";

import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";

export default function BookRecommendation({ title, listBooks }) {
  return (
    <div className={LAYOUT_PRIMARY + classes.bookRecommendation}>
      <div className={classes.recommendHeader}>
        <p className={classes.headerTitle}>{title}</p>
        <p className={classes.seeMore}>See more &gt;</p>
      </div>
      <ul className={classes.booksList}>
        {listBooks.map((book) => (
          <li className={classes.singleBook} key={book.bookId}>
            <Image src={book.imageUrl} alt="book" width={130} height={175} />
            <h3 className={classes.title}>{book.title}</h3>
            <p className={classes.author}>{book.author}</p>
            <p className={classes.originalPrice}>${book.originalPrice}</p>
          </li>
        ))}
      </ul>
    </div>
  );
}
