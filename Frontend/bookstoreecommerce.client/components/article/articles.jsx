import ArticleItem from "./article-item";

import classes from "@/styles/common/articles.module.css";

import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import { DUMMY_ARTICLES } from "@/lib/constant/constantData";

export default function Articles() {
  return (
    <div className={LAYOUT_PRIMARY + classes.articles}>
      <ArticleItem item={DUMMY_ARTICLES[0]} />
      <ArticleItem item={DUMMY_ARTICLES[1]} isReverse={true} />
    </div>
  );
}
