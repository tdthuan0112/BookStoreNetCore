import AccountNavigation from "@/components/account/account-navigation.jsx";
import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/account-layout.module.css";

export default function AccountLayout({ children }) {
  return (
    <div className={LAYOUT_PRIMARY + classes.accountLayout}>
      <AccountNavigation />
      <div className={classes.mainContent}>{children}</div>
    </div>
  );
}
