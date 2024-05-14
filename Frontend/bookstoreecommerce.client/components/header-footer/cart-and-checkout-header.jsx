import Image from "next/image";
import Link from "next/link";

import bookStoreLogo from "@/assets/img/bookStoreLogo-red.png";
import BreadCrumb from "@/components/common/bread-crumb";

import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/cart-and-checkout-header.module.css";

export default function CartAndCheckoutHeader() {
  return (
    <div className={LAYOUT_PRIMARY + classes.cartAndCheckoutHeader}>
      <div className={classes.logoAndTitle}>
        <Link className={classes.link} href="/">
          <Image src={bookStoreLogo} height={80} alt="" />
          <h1 className={classes.bookStoreTitle}>BookStore</h1>
        </Link>
      </div>
      <BreadCrumb />
    </div>
  );
}
