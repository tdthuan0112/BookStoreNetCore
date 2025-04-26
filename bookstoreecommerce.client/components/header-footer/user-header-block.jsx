import { getCurrentUserLoggedInAction } from "@/actions/user-actions";
import AdminHeaderBlock from "./admin-header-block";
import BuyerHeaderBlock from "./buyer-header-block";

export default async function UserHeaderBlock() {
  var userDetail = await getCurrentUserLoggedInAction();
  const isAdmin = userDetail.role.roleName === "Administrator";
  const isBuyer = userDetail.role.roleName === "Buyer";
  return (
    <>
      {isAdmin && <AdminHeaderBlock user={userDetail} />}
      {isBuyer && <BuyerHeaderBlock user={userDetail} />}
    </>
  );
}
