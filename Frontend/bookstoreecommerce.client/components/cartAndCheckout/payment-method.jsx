import { DUMMY_PAYMENT_METHODS } from "@/lib/constant/constantData";
import classes from "@/styles/common/payment-method.module.css";

export default function PaymentMethod() {
  return (
    <div className={classes.paymentMethod}>
      <h3>Payment Method</h3>
      <div className={classes.listMethods}>
        {DUMMY_PAYMENT_METHODS.map((paymentMethodItem) => (
          <p key={paymentMethodItem.id} className={classes.inputItem}>
            <input type="radio" defaultChecked name="paymentMethod" />
            <label>{paymentMethodItem.methodName}</label>
          </p>
        ))}
      </div>
    </div>
  );
}
