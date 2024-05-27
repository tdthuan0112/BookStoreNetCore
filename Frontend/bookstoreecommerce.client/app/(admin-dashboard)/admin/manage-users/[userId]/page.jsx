import Image from "next/image";

import { getUserDetailByIdAction } from "@/actions/user-actions";
import classes from "@/styles/layout/admin-manage-user-detail-page.module.css";
import userCircleImg from "@/assets/img/user-circle-solid.png";
import { getGenderById } from "@/lib/helper/common-helper";
import { BTN_PRIMARY } from "@/lib/constant/constantCssName";
import { navigateAdminManageOrderByUserId } from "@/lib/helper/navigate-helper";

export default async function AdminManageUserDetailPage({ params }) {
  const userId = params.userId;
  const user = await getUserDetailByIdAction(userId);

  return (
    <div>
      <h2>User #{user.userId}</h2>
      <div className={classes.mainContainer}>
        <div className={classes.userInfoContainer}>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Username</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={user.userName}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>First Name</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={user.firstName}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Last Name</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={user.lastName}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Email</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={user.email}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Gender</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={getGenderById(user.gender)}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Phone Number</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={user.phoneNumber}
            />
          </div>
          <div className={classes.infoRow}>
            <p className={classes.infoTitle}>Full Address</p>
            <input
              className={classes.infoInput}
              type="text"
              defaultValue={`${user.address} ${user.ward} ${user.district} ${user.province}`}
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
          <button className={classes.deleteButton}>Delete user</button>
        </form>
      </div>
    </div>
  );
}
