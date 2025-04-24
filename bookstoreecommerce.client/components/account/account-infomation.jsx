"use client";

import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import { isNullOrUndefined } from "@/lib/helper/common-helper";
import { navigateEditBuyerAccount } from "@/lib/helper/navigate-helper";
import classes from "@/styles/common/account-infomation.module.css";

export default function AccountInfomation({ userDetail, searchParams }) {
  const isViewMode =
    isNullOrUndefined(searchParams) || searchParams.mode != "edit";
  const isEditMode = searchParams.mode === "edit";
  let button;
  if (isViewMode) {
    button = (
      <button
        className={BTN_PRIMARY + classes.editButton}
        type="submit"
        formAction={navigateEditBuyerAccount}
      >
        Edit
      </button>
    );
  } else if (isEditMode) {
    button = (
      <button className={BTN_PRIMARY + classes.editButton} type="submit">
        Update
      </button>
    );
  }
  return (
    <>
      <h2>Account infomation</h2>
      <form className={classes.accountInfo}>
        <div className={classes.dataRow}>
          <p>Username</p>
          <p className={classes.userName}>ThuanTran</p>
        </div>
        <DataRow
          labelText="First Name"
          defaultValue="Thuan"
          disabled={!isEditMode}
        />
        <DataRow
          labelText="Last Name"
          defaultValue="Tran"
          disabled={!isEditMode}
        />
        <DataRow
          labelText="Phone"
          defaultValue="(+84) 123 456 789"
          disabled={!isEditMode}
        />
        <DataRow
          labelText="Email"
          defaultValue="thuanmaildemo@gmail.com"
          disabled={!isEditMode}
        />
        {/* Gender */}
        {/* BirthDay */}
        <DataRow
          type="date"
          labelText="Birthday"
          defaultValue="2017-06-01"
          disabled={!isEditMode}
        />
        <DataRow
          type="password"
          labelText="Cureent password"
          defaultValue="123456"
          disabled={!isEditMode}
        />
        <DataRow
          type="password"
          labelText="New password"
          defaultValue="123456"
          disabled={!isEditMode}
        />
        <DataRow
          type="password"
          labelText="Re-type password"
          defaultValue="12345"
          disabled={!isEditMode}
        />
        {button}
      </form>
    </>
  );
}

function DataRow({
  type = "text",
  labelText,
  defaultValue,
  placeholder,
  disabled = true,
}) {
  return (
    <div className={classes.dataRow}>
      <label className={classes.labelText}>{labelText}</label>
      <input
        className={classes.inputText}
        type={type}
        defaultValue={defaultValue}
        placeholder={placeholder}
        disabled={disabled}
      />
    </div>
  );
}
