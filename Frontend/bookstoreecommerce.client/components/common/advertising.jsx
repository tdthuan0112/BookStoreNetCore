import Image from "next/image";

import freeShippingIcon from "@/assets/img/freeship.png";
import giftsAndSalesIcon from "@/assets/img/giftsandsales.png";
import messageSupportIcon from "@/assets/img/messageSupport.png";
import paymentCartIcon from "@/assets/img/paymentCart.png";
import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";

import classes from "@/styles/common/advertising.module.css";

export default function Advertising() {
  return (
    <ul className={LAYOUT_PRIMARY + classes.advertising}>
      <li>
        <Image src={freeShippingIcon} height={50} alt="freeShippingIcon" />
        <p className={classes.title}>Free Shipping</p>
        <p className={classes.description}>Delivery in 3 days</p>
      </li>
      <li>
        <Image src={giftsAndSalesIcon} height={50} alt="giftsAndSalesIcon" />
        <p className={classes.title}>Gifts and Sales</p>
        <p className={classes.description}>Gift with everyone</p>
      </li>
      <li>
        <Image src={messageSupportIcon} height={50} alt="messageSupportIcon" />
        <p className={classes.title}>Online Support</p>
        <p className={classes.description}>Online Support 24/7</p>
      </li>
      <li>
        <Image src={paymentCartIcon} height={50} alt="paymentCartIcon" />
        <p className={classes.title}>Secure Payment</p>
        <p className={classes.description}>Fast and secure payments</p>
      </li>
    </ul>
  );
}
