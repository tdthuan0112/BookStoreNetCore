import Image from "next/image";
import Link from "next/link";

import classes from "@/styles/common/article-item.module.css";

export default function ArticleItem({ item, isReverse }) {
  return (
    <div className={classes.articleItem}>
      <div className={classes.content}>
        <h1>{item.title}</h1>
        <p
          className={classes.description}
          dangerouslySetInnerHTML={{ __html: item.description }}
        ></p>
        <Link className={classes.learnMore} href={item.url}>
          LEARN MORE
        </Link>
      </div>
      <Image
        className={isReverse ? classes.reverse : undefined}
        src={item.image}
        height={250}
        style={{ objectFit: "fill" }}
        alt={item.image}
      />
    </div>
  );
}
