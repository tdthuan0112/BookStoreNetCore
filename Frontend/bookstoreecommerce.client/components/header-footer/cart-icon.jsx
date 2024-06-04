"use client";
import Image from "next/image";
import { usePathname } from "next/navigation";

import cartIcon from "@/assets/img/cart.png";
import classes from "@/styles/common/cart-icon.module.css";
import { handleClickCartIcon } from "@/actions/cart-actions";

export default function CartIcon() {
  const pathName = usePathname();
  return (
    <Image
      className={classes.cartIcon}
      src={cartIcon}
      height={32}
      alt="cartIcon"
      onClick={async () => {
        await handleClickCartIcon(pathName);
      }}
    />
  );
}
