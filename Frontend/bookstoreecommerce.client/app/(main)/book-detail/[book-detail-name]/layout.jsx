import classes from "@/styles/layout/book-detail-layout.module.css";

export default function BookDetailLayout({ children }) {
  return <div className={classes.layout}>{children}</div>;
}
