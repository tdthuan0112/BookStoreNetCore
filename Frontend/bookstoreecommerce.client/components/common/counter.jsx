"use client";

import { useEffect, useState } from "react";
import classes from "@/styles/common/counter.module.css";
import { isNullOrUndefined, isType } from "@/lib/helper/common-helper";

export default function Counter({
  name,
  max,
  intialValue = 1,
  onHandleUpdateCart,
}) {
  const [counter, setCounter] = useState(intialValue);

  if (
    !isNullOrUndefined(onHandleUpdateCart) &&
    isType(onHandleUpdateCart, "function")
  ) {
    useEffect(() => {
      onHandleUpdateCart(counter);
    }, [counter]);
  }

  function handleDecrease() {
    setCounter((prevCounter) => {
      if (prevCounter === 1) return 1;
      return prevCounter - 1;
    });
  }

  function handleIncrease() {
    setCounter((prevCounter) => {
      if (prevCounter === max) return max;
      return prevCounter + 1;
    });
  }

  function onHandleChange(event) {
    let newValue = event.target.value === "" ? 0 : parseInt(event.target.value);
    if (newValue === 0) {
      setCounter("");
      return;
    }
    if (newValue > max) {
      setCounter(max);
    } else if (newValue < 1) setCounter(1);
    else setCounter(newValue);
  }

  function onHandleBlur(event) {
    let newValue = parseInt(event.target.value);
    if (!newValue) setCounter(1);
  }
  return (
    <div className={classes.inputQuantity}>
      <button type="submit" formAction={handleDecrease}>
        -
      </button>
      <input
        type="number"
        onChange={onHandleChange}
        onBlur={onHandleBlur}
        value={counter}
        name={name}
      />
      <button type="submit" formAction={handleIncrease}>
        +
      </button>
    </div>
  );
}
