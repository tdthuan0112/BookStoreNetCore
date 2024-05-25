import Image from "next/image";
import defaultImageSquare from "@/assets/img/image-square.png";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/common/book-detail-form.module.css";

export default function BookDetailForm({ book, mode }) {
  const isEditMode = mode === "edit";
  const isAddNewBookMode = mode === "addNewBook";
  return (
    <>
      {isEditMode && <EditBookDetailForm book={book} isEditMode={isEditMode} />}
      {isAddNewBookMode && <AddNewBookDetailForm />}
    </>
  );
}

function EditBookDetailForm({ book, isEditMode }) {
  return (
    <form className={classes.mainContainer}>
      <Image src={book.imageUrl} width={200} height={280} alt={book.title} />
      <div className={classes.contentContainer}>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p>
              Book Title <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input
              type="text"
              defaultValue={book.title}
              disabled={!isEditMode}
            />
          </div>
          <div className={classes.singleProperty}>
            <p>
              Original Price{" "}
              <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input
              type="text"
              defaultValue={book.originalPrice}
              disabled={!isEditMode}
            />
          </div>
        </div>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p>
              Author <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input
              type="text"
              defaultValue={book.author}
              disabled={!isEditMode}
            />
          </div>
          <div className={classes.singleProperty}>
            <p>
              Discount Price
              <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input
              type="text"
              defaultValue={book.discountPrice}
              disabled={!isEditMode}
            />
          </div>
        </div>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p>
              Book Url <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" defaultValue={book.url} disabled={!isEditMode} />
          </div>
          <div className={classes.singleProperty}>
            <p>Discount Type</p>
            <div className={classes.discountTypeInput}>
              <label htmlFor="percent">Percent</label>
              <input
                type="radio"
                name="discountType"
                id="percent"
                defaultChecked={book.isDiscountPercent}
              ></input>
              <label htmlFor="price">Price</label>
              <input
                type="radio"
                name="discountType"
                id="price"
                defaultChecked={!book.isDiscountPercent}
              ></input>
            </div>
          </div>
        </div>
        <div className={classes.singleProperty}>
          <p>
            Image Url <strong className={classes.requiredProperty}>*</strong>
          </p>
          <input
            type="text"
            defaultValue={book.imageUrl}
            disabled={!isEditMode}
          />
        </div>
        <div className={classes.singleProperty}>
          <p>
            Category <strong className={classes.requiredProperty}>*</strong>
          </p>
          <input
            type="text"
            defaultValue={book.imageUrl}
            disabled={!isEditMode}
          />
        </div>
        <div className={classes.singleProperty}>
          <p>
            Description <strong className={classes.requiredProperty}>*</strong>
          </p>
          <textarea defaultValue={book.description} disabled={!isEditMode} />
        </div>
        <div className={classes.buttonBlock}>
          <button className={classes.btnDeleteBook}>DELETE BOOK</button>
          <button className={BTN_PRIMARY + classes.btnSaveBook}>SAVE</button>
        </div>
      </div>
    </form>
  );
}

function AddNewBookDetailForm() {
  return (
    <form className={classes.mainContainer}>
      <Image
        src={defaultImageSquare}
        width={200}
        height={280}
        alt="Default Image Square"
      />
      <div className={classes.contentContainer}>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p>
              Book Title <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" placeholder="Book Title" />
          </div>
          <div className={classes.singleProperty}>
            <p>
              Original Price{" "}
              <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" placeholder="Original Price" />
          </div>
        </div>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p>
              Author <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" placeholder="Author" />
          </div>
          <div className={classes.singleProperty}>
            <p>
              Discount Price
              <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" placeholder="Discount Price" />
          </div>
        </div>
        <div className={classes.columnTemplate}>
          <div className={classes.singleProperty}>
            <p>
              Book Url <strong className={classes.requiredProperty}>*</strong>
            </p>
            <input type="text" placeholder="http:// ..." />
          </div>
          <div className={classes.singleProperty}>
            <p>Discount Type</p>
            <div className={classes.discountTypeInput}>
              <label htmlFor="percent">Percent</label>
              <input
                type="radio"
                name="discountType"
                id="percent"
                checked
              ></input>
              <label htmlFor="price">Price</label>
              <input type="radio" name="discountType" id="price"></input>
            </div>
          </div>
        </div>
        <div className={classes.singleProperty}>
          <p>
            Image Url <strong className={classes.requiredProperty}>*</strong>
          </p>
          <input type="text" placeholder="http:// ..." />
        </div>
        <div className={classes.singleProperty}>
          <p>
            Category <strong className={classes.requiredProperty}>*</strong>
          </p>
          <input type="text" placeholder="Category" />
        </div>
        <div className={classes.singleProperty}>
          <p>
            Description <strong className={classes.requiredProperty}>*</strong>
          </p>
          <textarea placeholder="Description" />
        </div>
        <div className={classes.buttonBlock}>
          <button className={BTN_PRIMARY + classes.btnSaveBook}>
            ADD NEW BOOK
          </button>
        </div>
      </div>
    </form>
  );
}
