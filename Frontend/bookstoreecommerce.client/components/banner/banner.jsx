import Image from "next/image";
import Link from "next/link";

import { BTN_PRIMARY, LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";

import bannerImg from "@/assets/img/banner.png";
import classes from "@/styles/common/banner.module.css";

export default function Banner() {
  return (
    <div className={classes.bannerBackground}>
      <div className={LAYOUT_PRIMARY + classes.bannerContent}>
        <div className={classes.content}>
          <h1 className={classes.title}>It starts here</h1>
          <p className={classes.description}>
            The independent bookshop with tradition values
          </p>
          <Link href="/all-books" className={BTN_PRIMARY + classes.button}>
            Browse Books
          </Link>
        </div>
        <Image src={bannerImg} height={350} alt="Banner Image" />
      </div>
    </div>
  );
}
