import Image from "next/image";
import Link from "next/link";

import userCircleImg from "@/assets/img/user-circle-solid.png";
import { getAllUsersAction } from "@/actions/user-actions";
import classes from "@/styles/layout/admin-manage-users-page.module.css";
import CustomIcon from "@/components/common/custom-icon";

export default async function AdminManageUsersPage() {
  const users = await getAllUsersAction();
  return (
    <div>
      <h3>Mangage Users</h3>
      <div className={classes.mainContainer}>
        {users.map((user) => (
          <Link
            href={`/admin/manage-users/${user.userId}`}
            key={user.userId}
            className={classes.userCard}
          >
            <CustomIcon
              width={36}
              height={36}
              icon="teenyicons:user-circle-solid"
            />
            <div className={classes.userInfo}>
              <p className={classes.fullName}>
                {user.firstName} {user.lastName}
              </p>
              <p>Email: {user.email}</p>
              <p>Phone: {user.phoneNumber}</p>
            </div>
          </Link>
        ))}
      </div>
    </div>
  );
}
