import Image from "next/image";

import { getAllBooksAction } from "@/actions/book-actions";
import classes from "@/styles/layout/admin-manage-books-age.module.css";
import { navigateAdminEditBookDetail } from "@/lib/helper/navigate-helper";

export default async function ManageBooksPage() {
  const listBooks = await getAllBooksAction();
  return (
    <div>
      <h3>Manage Books</h3>
      <form className={classes.mainContainer}>
        {listBooks.map((book) => {
          const isHaveDiscount = book.discountPrice > 0;
          return (
            <div className={classes.bookCard} key={book.id}>
              <Image
                src={book.imageUrl}
                width={120}
                height={180}
                alt={book.title}
              />
              <div className={classes.bookInfo}>
                <h3>{book.title}</h3>
                <p>{book.author}</p>
                <div className={classes.priceBlock}>
                  <p className={classes.finalPrice}>$ {book.finalPrice}</p>
                  {isHaveDiscount && (
                    <>
                      <p className={classes.originalPrice}>
                        {book.originalPrice}
                      </p>
                      {book.isDiscountPercent && (
                        <p className={classes.salePercent}>
                          Sale {book.discountPrice}%
                        </p>
                      )}
                    </>
                  )}
                </div>
                <p className={classes.bookDescription}>{book.description}</p>
                <input type="hidden" name="bookId" value={book.bookId} />
                <button
                  type="submit"
                  formAction={navigateAdminEditBookDetail}
                  className={classes.btnEditBook}
                >
                  Edit book
                </button>
              </div>
            </div>
          );
        })}
      </form>
    </div>
  );
}
