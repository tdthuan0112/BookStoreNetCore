import Image from "next/image";
import Link from "next/link";

import {
  deleteUserByUserIdAction,
  getUserDetailByIdAction,
  updateUserDetail
} from "@/actions/user-actions";

import classes from "@/styles/layout/admin-manage-user-detail-page.module.css";
import userCircleImg from "@/assets/img/user-circle-solid.png";

import { getGenderById } from "@/lib/helper/common-helper";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import { navigateAdminManageOrderByUserId } from "@/lib/helper/navigate-helper";

import CustomIcon from "@/components/common/custom-icon"
import { GENDER_TYPES } from "@/lib/constant/constantType";

export default async function AdminManageUserDetailPage({ params, searchParams }) {
  const userId = params.userId;
  const user = await getUserDetailByIdAction(userId);
  const { mode = '' } = await searchParams
  let isEditMode = mode === "edit";

  return (
    <form>
      <div className={classes.headerBlock}>
        <h2>User - {`${user.firstName} ${user.lastName}`}</h2>
        {!isEditMode ?
          <Link
            className={BTN_PRIMARY + classes.btnEdit}
            href={`/admin/manage-users/${userId}?mode=edit`}
          >
            <CustomIcon icon="fa-regular:edit" width="15" height="15" />
            Edit
          </Link>
          :
          <button
            formAction={updateUserDetail}
            className={BTN_PRIMARY + classes.btnEdit}
          >
            <CustomIcon icon="lucide:save" width="15" height="15" />
            Save
          </button>}
      </div>
      <div className={classes.mainContainer}>
        <div className={classes.userInfoContainer}>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Username</p>
            <input
              className={classes.infoInput}
              name="userName"
              type="text"
              defaultValue={user.userName}
              disabled={true}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>First Name</p>
            <input
              className={classes.infoInput}
              type="text"
              name="firstName"
              defaultValue={user.firstName}
              disabled={!isEditMode}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Last Name</p>
            <input
              className={classes.infoInput}
              type="text"
              name="lastName"
              defaultValue={user.lastName}
              disabled={!isEditMode}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Email</p>
            <input
              className={classes.infoInput}
              type="text"
              name="email"
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
              <select id="gender" name="gender" className={classes.infoInput} defaultValue={user.gender}>
                <option value={GENDER_TYPES.Male.id}>Male</option>
                <option value={GENDER_TYPES.Female.id}>Female</option>
              </select>
            }
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Phone Number</p>
            <input
              className={classes.infoInput}
              type="text"
              name="phoneNumber"
              defaultValue={user.phoneNumber}
              disabled={!isEditMode}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Full Address</p>
            <input
              className={classes.infoInput}
              type="text"
              name="adress"
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
        <div className={classes.buttonForm}>
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
        </div>
      </div>
    </form>
  );
}
