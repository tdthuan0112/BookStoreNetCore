"use client";
import Link from "next/link";
import { useState } from "react";

import CustomIcon from "@/components/common/custom-icon";

import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import classes from "@/styles/common/admin-header-block.module.css";
import { logoutAction } from "@/actions/authentication-actions";

export default function BuyerHeaderBlock({ user }) {
  const [isShowQuickMenu, setIsShowQuickMenu] = useState(false);
  return (
    <div
      className={classes.adminHeaderBlock}
      onMouseEnter={() => setIsShowQuickMenu(true)}
      onMouseLeave={() => setIsShowQuickMenu(false)}
    >
      <Link href="/account" className={classes.authenticated}>
        <CustomIcon
          width={18}
          height={18}
          icon="teenyicons:user-circle-solid"
        />
        <p>
          {user.firstName} {user.lastName}
        </p>
      </Link>
      {isShowQuickMenu && (
        <div className={classes.quickMenu}>
          <Link href="/account">Account Infomation</Link>
          <Link href="/account/orders">Manage Orders</Link>
          <Link href="/account/billings">Manage Billings</Link>
          <Link href="/account/addresses">Manage Addresses</Link>
          <hr className={classes.hrLine} />
          <button
            onClick={async () => {
              await logoutAction();
            }}
            className={BTN_PRIMARY + classes.logoutBtn}
          >
            Logout
          </button>
        </div>
      )}
    </div>
  );
}
