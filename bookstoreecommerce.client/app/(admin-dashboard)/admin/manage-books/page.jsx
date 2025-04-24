import Image from "next/image";
import Link from "next/link";

import CustomIcon from "@/components/common/custom-icon.jsx";

import classes from "@/styles/layout/admin-manage-books-page.module.css";

import { getAllBooksAction } from "@/actions/book-actions";
import { navigateAdminEditBookDetail } from "@/lib/helper/navigate-helper";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";

export default async function ManageBooksPage() {
  const listBooks = await getAllBooksAction();
  return (
    <div>
      <div className={classes.headerBlock}>
        <h3>Manage Books</h3>
        <Link
          className={BTN_PRIMARY + classes.btnAddNewBook}
          href="/admin/manage-books/add-new-book"
        >
          <CustomIcon icon="carbon:add-filled" />
          Add new book
        </Link>
      </div>
      <div className={classes.mainContainer}>
        {listBooks.map((book) => {
          const isHaveDiscount = book.discountPrice > 0;
          return (
            <div className={classes.bookCard} key={book.id} bookid={book.id}>
              <Image
                src={book.imageUrl}
                width={120}
                height={180}
                alt={book.title}
              />
              <form className={classes.bookInfo}>
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
              </form>
            </div>
          );
        })}
      </div>
    </div>
  );
}
