import Link from "next/link";
//Component
import FullAddressBox from "@/components/common/full-address-box";
//Css
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/signup-page.module.css";
import { createUserAction } from "@/actions/user-actions";

export default async function SignupPage() {
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
      <form action={createUserAction} className={classes.userInputForm}>
        <input type="text" placeholder="Username" name="userName" />
        <input type="password" placeholder="Password" name="password" />
        <input type="text" placeholder="FirstName" name="firstName" />
        <input type="text" placeholder="LastName" name="lastName" />
        <input type="text" placeholder="Email" name="email" />
        <input type="number" placeholder="PhoneNumber" name="phoneNumber" />
        <FullAddressBox />
        <input type="date" placeholder="PhoneNumber" name="dateOfBirth" />
        <button type="submit" className={BTN_PRIMARY + classes.loginBtn}>
          Sign up
        </button>
      </form>
    </div>
  );
}
