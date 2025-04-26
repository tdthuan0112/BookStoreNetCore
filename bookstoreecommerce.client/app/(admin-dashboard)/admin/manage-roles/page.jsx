import { getAllRolesAction } from "@/actions/role-actions";
import { transformDateTimeValue } from "@/lib/helper/common-helper.js";

import CustomIcon from "@/components/common/custom-icon.jsx";

import classes from "@/styles/layout/admin-manage-roles-page.module.css";

export default async function AdminManageRolesPage() {
  const listRoles = await getAllRolesAction();
  return (
    <div className={classes.adminManageRolesPage}>
      <div className={classes.headerBlock}>
        <h3>Manage Roles</h3>
      </div>
      <table className={classes.mainContainer}>
        <tbody>
          <tr>
            <th>Role ID</th>
            <th>Role Name</th>
            <th>Created By</th>
            <th>Date created</th>
            <th>Active</th>
          </tr>
          {listRoles.map((role) => (
            <tr key={role.roleId} className={classes.roleItem}>
              <td>{role.roleId}</td>
              <td>{role.roleName}</td>
              <td>{role.createdBy}</td>
              <td>{transformDateTimeValue(role.dateCreated)}</td>
              <td>
                <CustomIcon
                  icon={
                    role.isActive
                      ? "fluent:checkbox-checked-20-filled"
                      : "fluent:checkbox-unchecked-20-filled"
                  }
                  width={24}
                  height={24}
                />
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
