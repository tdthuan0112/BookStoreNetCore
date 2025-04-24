import { LAYOUT_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/layout/main-footer.module.css";

export default function MainFooter() {
  return (
    <footer className={classes.footer}>
      <main className={LAYOUT_PRIMARY}>
        <div>
          <h1>
            Book<span className={classes.highlight}>Store</span>
          </h1>
          <p>Ho Chi Minh, VN</p>
          <p>P.O. BOX: 123456</p>
          <p>Phone: (+84) 123 456 789</p>
          <p>Mail: addmin@bookstore.com</p>
        </div>
        <div>
          <h3>Shop Guide</h3>
          <p>About us</p>
          <p>Deliver Infomation</p>
          <p>Privacy Policy</p>
          <p>Term & Conditions</p>
          <p>Services</p>
        </div>
        <div>
          <h3>Account Info</h3>
          <p>My Account</p>
          <p>My Wishlist</p>
          <p>My Cart</p>
          <p>Sign in</p>
          <p>Check out</p>
        </div>
        <div>
          <h3>Keep In Touch With Us</h3>
          <p>Facebook</p>
          <p>Twitter</p>
          <p>Instagram</p>
          <p>Linkedin</p>
          <p>Carrers</p>
        </div>
      </main>
    </footer>
  );
}
