import classes from "@/styles/layout/cart-page-layout.module.css";

export default function CartPageLayout({ children }) {
  return <div className={classes.layout}>{children}</div>;
}
