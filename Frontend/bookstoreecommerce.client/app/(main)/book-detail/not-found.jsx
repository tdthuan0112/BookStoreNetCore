"use client";

import Image from "next/image";
import Link from "next/link";
import { usePathname } from "next/navigation";

import pageNotFoundImg from "@/assets/img/404-page-notfound.png";
import classes from "@/styles/layout/not-found-book-detail.module.css";

import { capitalizeFirstLetter } from "@/lib/helper/url-helper";
import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";

export default function NotFoundBookDetail() {
  const pathName = usePathname();
  const bookUrl = pathName.split("/").pop();

  const bookName = capitalizeFirstLetter(bookUrl.replaceAll("-", " "));

  return (
    <div className={LAYOUT_PRIMARY + classes.notFound}>
      <h1 className={classes.title}>
        Sorry we could not found your book name "{bookName}""
      </h1>
      <div className={classes.notFoundContent}>
        <Image age src={pageNotFoundImg} width={900} />
        <Link href={"/all-books"}>
          <button className={BTN_PRIMARY + classes.button}>Browse Books</button>
        </Link>
      </div>
    </div>
  );
}
