import AdminNavigation from "@/components/admin/admin-navigation";
import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/admin-layout.module.css";

export default function AdminLayout({ children }) {
  return (
    <div className={classes.adminLayout}>
      <AdminNavigation />
      <div className={classes.mainContent}>{children}</div>
    </div>
  );
}
