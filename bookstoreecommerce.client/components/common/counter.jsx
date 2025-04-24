"use client";

import { useEffect, useState, useRef, useLayoutEffect } from "react";
import classes from "@/styles/common/counter.module.css";
import { isNullOrUndefined, isType } from "@/lib/helper/common-helper";

export default function Counter({
  name,
  max,
  type,
  intialValue = 1,
  onHandleUpdateCart,
}) {
  const [counter, setCounter] = useState(intialValue);
  const isMounted = useRef(false);

  useEffect(() => {
    if (isMounted.current) {
      if (isType(onHandleUpdateCart, "function")) {
        onHandleUpdateCart(counter);
      }
    } else {
      isMounted.current = true;
    }
  }, [counter]);

  let decreaseButon;
  let increaseButon;

  if (type === "submit") {
    decreaseButon = (
      <button type="submit" formAction={handleDecrease}>
        -
      </button>
    );
    increaseButon = (
      <button type="submit" formAction={handleIncrease}>
        +
      </button>
    );
  } else {
    decreaseButon = (
      <button onClick={handleDecrease} type="button">
        -
      </button>
    );
    increaseButon = (
      <button onClick={handleIncrease} type="button">
        +
      </button>
    );
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
      {decreaseButon}
      <input
        type="number"
        onChange={onHandleChange}
        onBlur={onHandleBlur}
        value={counter}
        name={name}
      />
      {increaseButon}
    </div>
  );
}
