import classes from "@/styles/common/quantity-counter.module.css";
import Counter from "@/components/common/counter";

export default function QuantityCounter({ max }) {
  return (
    <div className={classes.quantityDiv}>
      <p>Quantity</p>
      <Counter max={max} />
      <p>{`${max} ${max > 1 ? "availables" : "available"}`}</p>
    </div>
  );
}
