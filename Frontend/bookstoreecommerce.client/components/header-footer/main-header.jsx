import Image from "next/image";
import Link from "next/link";

import instaIcon from "@/assets/img/instagram.png";
import facebookIcon from "@/assets/img/facebook.png";
import notificationIcon from "@/assets/img/notification.png";
import helpIcon from "@/assets/img/help.png";
import bookStoreLogo from "@/assets/img/bookStoreLogo.png";
import searchIcon from "@/assets/img/search.png";
import cartIcon from "@/assets/img/cart.png";

import CartIcon from "./cart-icon";
import UserHeaderBlock from "./user-header-block";

import { isAuthenticatedAction } from "@/actions/authentication-actions";

import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/main-header.module.css";

export default async function MainHeader() {
  let userHeaderBlock;
  const isAuthenticated = await isAuthenticatedAction();
  if (!isAuthenticated) {
    userHeaderBlock = (
      <li className={classes.authentication}>
        <Link href="/buyer/login">Login</Link>|
        <Link href="/buyer/signup">Sign Up</Link>
      </li>
    );
  } else {
    userHeaderBlock = <UserHeaderBlock />;
  }
  return (
    <header className={classes.header}>
      <main className={LAYOUT_PRIMARY + classes.main}>
        <div className={classes.headerInfo}>
          <div className={classes.connect}>
            <p>Connect</p>
            <Image src={instaIcon} height={16} alt="instaIcon" />
            <Image src={facebookIcon} height={16} alt="fbIcon" />
          </div>
          <ul>
            <li>
              <Link href="/notifications">
                <Image
                  src={notificationIcon}
                  height={16}
                  alt="notificationIcon"
                />
                <p>Notification</p>
              </Link>
            </li>
            <li>
              <Link href="/support">
                <Image src={helpIcon} height={16} alt="helpIcon" />
                <p>Help</p>
              </Link>
            </li>
            {userHeaderBlock}
          </ul>
        </div>
        <div className={classes.headerInfo}>
          <Link href="/" className={classes.brand}>
            <Image src={bookStoreLogo} height={48} alt="BookStoreLogo" />
            <h1>BookStore</h1>
          </Link>
          <form className={classes.searchBar}>
            <input type="text" placeholder="Search for books..." />
            <button type="submit">
              <Image src={searchIcon} height={20} alt="searchIcon" />
            </button>
          </form>
          <CartIcon />
        </div>
      </main>
    </header>
  );
}
