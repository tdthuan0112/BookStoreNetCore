import { DUMMY_SHIPPING_METHODS } from "@/lib/constant/constantData";
import classes from "@/styles/common/shiping-method.module.css";

export default function ShippingMethod() {
  return (
    <div className={classes.shippingMethod}>
      <h3>Shipping Method</h3>
      <div className={classes.listMethods}>
        {DUMMY_SHIPPING_METHODS.map((shippingMethodItem) => (
          <div key={shippingMethodItem.id}>
            <div className={classes.methodItem}>
              <div className={classes.inputItem}>
                <input type="radio" defaultChecked name="shippingMethod" />
                <label>{shippingMethodItem.name}</label>
                <p>( {shippingMethodItem.description} )</p>
              </div>
              <p>$ {shippingMethodItem.price}</p>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}
