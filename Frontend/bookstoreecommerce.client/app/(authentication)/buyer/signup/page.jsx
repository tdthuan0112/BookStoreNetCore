import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/signup-page.module.css";
import Link from "next/link";

export default function SignupPage() {
  return (
    <div className={classes.signUpPage}>
      <div className={classes.header}>
        <h2>Sign Up</h2>
        <div className={classes.loginBlock}>
          <p className={classes.alreadyHaveAccount}>Already have account?</p>
          <Link className={classes.signUplink} href="/buyer/login">
            Login
          </Link>
        </div>
      </div>
      <form className={classes.userInputForm}>
        <input type="text" placeholder="Username" name="userName" />
        <input type="password" placeholder="Password" name="password" />
        <button type="submit" className={BTN_PRIMARY + classes.loginBtn}>
          Sign up
        </button>
      </form>
    </div>
  );
}
