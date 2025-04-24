import Link from "next/link";

import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/login-page.module.css";

import { loginAction } from "@/actions/authentication-actions.js";

export default function LoginPage() {
  return (
    <div className={classes.loginPage}>
      <div className={classes.header}>
        <h2>Login page</h2>
        <div className={classes.signupBlock}>
          <p className={classes.newToBookStore}>New to BookStore?</p>
          <Link className={classes.signUplink} href="/buyer/signup">
            Sign Up
          </Link>
        </div>
      </div>
      <form action={loginAction} className={classes.userInputForm}>
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
