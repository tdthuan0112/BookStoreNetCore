import Image from "next/image";

import ratingStarFullIcon from "@/assets/img/rating-star-full.png";
import ratingStarHalfIcon from "@/assets/img/rating-star-half.png";
import ratingStarEmptyIcon from "@/assets/img/rating-star-empty.png";

import { DUMMY_REVIEWS } from "@/lib/constant/constantData";

import classes from "@/styles/common/customer-review.module.css";

export default function CustomerReviews() {
  function fetchCustomerReviews() {}

  return (
    <>
      <h2 className={classes.customerReviewTitle}>CUSTOMER REVIEWS</h2>
      <div className={classes.customerReviewBlock}>
        <div className={classes.backgroundBlock}>
          <div className={classes.scoreAndFilter}>
            <div className={classes.scoreBlock}>
              <p className={classes.averageScore}>
                {DUMMY_REVIEWS.averageScore}/5
              </p>
              <div>
                <Image src={ratingStarFullIcon} width={24} alt="Rating" />
                <Image src={ratingStarFullIcon} width={24} alt="Rating" />
                <Image src={ratingStarFullIcon} width={24} alt="Rating" />
                <Image src={ratingStarFullIcon} width={24} alt="Rating" />
                <Image src={ratingStarHalfIcon} width={24} alt="Rating" />
              </div>
            </div>
            <div className={classes.fillerBlock}>
              <button>All ({DUMMY_REVIEWS.totalReviews})</button>
              <button>5 star (10)</button>
              <button>4 star (2)</button>
              <button>3 star (1)</button>
              <button>2 star (1)</button>
              <button>1 star (0)</button>
            </div>
          </div>
        </div>

        <div className={classes.reviewDetailBlock}>
          {DUMMY_REVIEWS.reviews.map((item) => {
            return (
              <div key={item.reviewId}>
                <p className={classes.userName}>{item.userName}</p>
                <p className={classes.dateCreated}>
                  {item.dateCreated.toDateString()}
                </p>
                <div>
                  <Image src={ratingStarFullIcon} width={24} alt="Rating" />
                  <Image src={ratingStarFullIcon} width={24} alt="Rating" />
                  <Image src={ratingStarFullIcon} width={24} alt="Rating" />
                  <Image src={ratingStarFullIcon} width={24} alt="Rating" />
                  <Image src={ratingStarHalfIcon} width={24} alt="Rating" />
                </div>
                <p>{item.comment}</p>
                <hr />
              </div>
            );
          })}
        </div>
      </div>
    </>
  );
}
