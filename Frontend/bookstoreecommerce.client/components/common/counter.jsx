"use client";

import { useState } from "react";
import classes from "@/styles/common/counter.module.css";

export default function Counter({ max, intialValue = 1 }) {
  const [counter, setCounter] = useState(intialValue);

  function decrease() {
    setCounter((prevCounter) => {
      if (prevCounter === 1) return 1;
      return prevCounter - 1;
    });
  }

  function increase() {
    setCounter((prevCounter) => {
      if (prevCounter === max) return max;
      return prevCounter + 1;
    });
  }

  function onHandleChange(event) {
    let newValue = parseInt(event.target.value);
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
      <button onClick={decrease}>-</button>
      <input
        type="number"
        onChange={onHandleChange}
        onBlur={onHandleBlur}
        value={counter}
        name="quantity"
      />
      <button onClick={increase}>+</button>
    </div>
  );
}
