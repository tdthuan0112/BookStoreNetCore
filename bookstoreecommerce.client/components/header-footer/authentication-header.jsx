import Image from "next/image";
import Link from "next/link";

import bookStoreLogo from "@/assets/img/bookStoreLogo-red.png";

import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/authentication-header.module.css";

export default function AuthenticationHeader({ pageName }) {
  return (
    <div className={LAYOUT_PRIMARY + classes.authenticationHeader}>
      <div className={classes.logoAndTitle}>
        <Link className={classes.link} href="/">
          <Image src={bookStoreLogo} height={80} alt="" />
          <h1 className={classes.bookStoreTitle}>BookStore</h1>
        </Link>
        <h1>{pageName}</h1>
      </div>
      <Link href="/" className={classes.needHelp}>
        Need help?
      </Link>
    </div>
  );
}
