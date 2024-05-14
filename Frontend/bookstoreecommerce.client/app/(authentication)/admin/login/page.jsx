import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/login-page.module.css";
import Link from "next/link";

export default function AdminLoginPage() {
  return (
    <div className={classes.loginPage}>
      <div className={classes.header}>
        <h2>BookStore - For Admin</h2>
      </div>
      <form className={classes.userInputForm}>
        <input type="text" placeholder="Username" name="userName" />
        <input type="password" placeholder="Password" name="password" />
        <button type="submit" className={BTN_PRIMARY + classes.loginBtn}>
          Login
        </button>
      </form>
      <Link className={classes.fogotPassword} href="/">
        Forgot password?
      </Link>
      <p></p>
    </div>
  );
}
