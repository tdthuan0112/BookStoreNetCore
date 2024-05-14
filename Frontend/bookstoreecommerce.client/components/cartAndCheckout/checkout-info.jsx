import classes from "@/styles/common/checkout-info.module.css";

export default function CheckoutInfo() {
  return (
    <div className={classes.checkoutInfo}>
      <div className={classes.infoItem}>
        <p className={classes.title}>Name</p>
        <p>Mr/Mrs. Tran Dinh Thuan</p>
      </div>
      <hr />
      <div className={classes.infoItem}>
        <p className={classes.title}>Phone Number</p>
        <p>(+84) 123 456 789</p>
      </div>
      <hr />
      <div className={classes.infoItem}>
        <p className={classes.title}>Email</p>
        <p>testEmail@gmail.com</p>
      </div>
      <hr />
      <div className={classes.infoItem}>
        <p className={classes.title}>Ship to</p>
        <p>123 News Times, 456 New York City, America</p>
      </div>
      <hr />
      <p className={classes.changeBtn}>Change</p>
    </div>
  );
}
