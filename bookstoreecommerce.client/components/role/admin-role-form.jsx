import classes from "@/styles/common/admin-category-form.module.css";

export default function AdminRoleForm({ role }) {
  const isEditMode = mode === "edit";

  return (
    <>
      {isEditMode && <EditRoleDetailForm role={role} />}
    </>
  )
}

function EditRoleDetailForm({ role }) {
  return (
    <form className={classes.adminCategoryForm}>
      <div className={classes.singleProperty}>
        <p htmlFor="name">
          Role Name <strong>*</strong>
        </p>
        <input type="text" name="name" defaultValue={role.roleName} />
      </div>
      <div className={classes.singleProperty}>
        <p htmlFor="createdBy">
          Created By
        </p>
        <input type="text" name="createdBy" defaultValue={role.createdBy} />
      </div>
      <div className={classes.singleProperty}>
        <p htmlFor="dateCreated">
          Date Created
        </p>
        <input type="text" name="dateCreated" defaultValue={role.dateCreated} />
      </div>
      <div className={classes.singleProperty}>
        <p htmlFor="modifiedBy">
          Modified By
        </p>
        <input type="text" name="modifiedBy" defaultValue={role.modifiedBy} disabled />
      </div>
      <div className={classes.singleProperty}>
        <p htmlFor="dateLastModified">
          Date Last Modify
        </p>
        <input type="text" name="dateLastModified" defaultValue={role.dateLastModified} disabled />
      </div>
    </form>
  )
}