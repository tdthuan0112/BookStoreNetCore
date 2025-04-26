import Image from "next/image";
import Link from "next/link";

import {
  deleteUserByUserIdAction,
  getUserDetailByIdAction,
} from "@/actions/user-actions";

import classes from "@/styles/layout/admin-manage-user-detail-page.module.css";
import userCircleImg from "@/assets/img/user-circle-solid.png";

import { getGenderById } from "@/lib/helper/common-helper";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import { navigateAdminManageOrderByUserId } from "@/lib/helper/navigate-helper";

import CustomIcon from "@/components/common/custom-icon"

export default async function AdminManageUserDetailPage({ params, searchParams }) {
  const userId = params.userId;
  const user = await getUserDetailByIdAction(userId);
  const { mode = '' } = await searchParams
  let isEditMode = mode === "edit";

  return (
    <div>
      <div className={classes.headerBlock}>
        <h2>User - {`${user.firstName} ${user.lastName}`}</h2>
        <Link
          className={BTN_PRIMARY + classes.btnEdit}
          href={`/admin/manage-users/${userId}?mode=edit`}
        >
          <CustomIcon icon={isEditMode ? "lucide:save" : "fa-regular:edit"} width="15" height="15" />
          {isEditMode ? "Save" : "Edit"}
        </Link>
      </div>
      <div className={classes.mainContainer}>
        <div className={classes.userInfoContainer}>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Username</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={user.userName}
              disabled={!isEditMode}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>First Name</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={user.firstName}
              disabled={!isEditMode}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Last Name</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={user.lastName}
              disabled={!isEditMode}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Email</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={user.email}
              disabled={!isEditMode}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Gender</p>
            {!isEditMode ?
              <input
                className={classes.infoInput}
                type="text"
                defaultValue={getGenderById(user.gender)}
                disabled
              /> :
              <select id="gender" name="gender">
                <option value="volvo">Male</option>
                <option value="audi">Female</option>
              </select>
            }
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Phone Number</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={user.phoneNumber}
              disabled={!isEditMode}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Full Address</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={`${user.address} ${user.wardName} ${user.districtName} ${user.provinceName}`}
              disabled={!isEditMode}
            />
          </div>
        </div>
        <Image
          src={userCircleImg}
          width={150}
          height={150}
          alt="User Circle Image"
        />
        <form className={classes.buttonForm}>
          <input type="hidden" name="userId" defaultValue={user.userId} />
          <button
            type="submit"
            formAction={navigateAdminManageOrderByUserId}
            className={BTN_PRIMARY}
          >
            Orders of user
          </button>
          <button
            formAction={deleteUserByUserIdAction}
            className={classes.deleteButton}
          >
            Delete user
          </button>
        </form>
      </div>
    </div>
  );
}
