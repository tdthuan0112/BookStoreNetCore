"use client";

import Link from "next/link";
import Image from "next/image";

import { usePathname } from "next/navigation";

import viewListImg from "@/assets/img/view-list.png";
import bookEditImg from "@/assets/img/book-edit.png";
import userEditImg from "@/assets/img/user-edit.png";
import categoryEditImg from "@/assets/img/category.png";
import appUsersRoles from "@/assets/img/app-users-roles.png";

import classes from "@/styles/common/admin-navigation.module.css";

export default function AdminNavigation() {
  const pathname = usePathname();
  const isManageOrderPage = pathname === "/admin/manage-orders";
  const isManageBookPage = pathname === "/admin/manage-books";
  const isManageUserPage = pathname === "/admin/manage-users";
  const isManageCategoryPage = pathname === "/admin/manage-categories";
  const isManageRolePage = pathname === "/admin/manage-roles";

  const navigationItems = [
    {
      key: 1,
      name: "manageOrderPage",
      href: "/admin/manage-orders",
      isActive: isManageOrderPage,
      icon: viewListImg,
      alt: "Account Image",
      displayText: "Manage Orders"
    },
    {
      key: 2,
      name: "manageBookPage",
      href: "/admin/manage-books",
      isActive: isManageBookPage,
      icon: bookEditImg,
      alt: "Book Edit Image",
      displayText: "Manage Books"
    },
    {
      key: 3,
      name: "manageUserPage",
      href: "/admin/manage-users",
      isActive: isManageUserPage,
      icon: userEditImg,
      alt: "User Edit Image",
      displayText: "Manage Users"
    },
    {
      key: 4,
      name: "manageCategoryPage",
      href: "/admin/manage-categories",
      isActive: isManageCategoryPage,
      icon: categoryEditImg,
      alt: "Category Edit Image",
      displayText: "Manage Categories"
    },
    {
      key: 5,
      name: "manageRolePage",
      href: "/admin/manage-roles",
      isActive: isManageRolePage,
      icon: appUsersRoles,
      alt: "Role Edit Image",
      displayText: "Manage Roles"
    },
  ]

  return (
    <div>
      <div>
        <p>Admin Account of</p>
        <p>
          <strong>Thuan Tran</strong>
        </p>
      </div>
      {navigationItems.map(item => (
        <Link
          key={item.key}
          href={item.href}
          className={`${classes.navLink} ${item.isActive ? classes.activeLink : undefined
            }`}
        >
          <Image src={item.icon} with={20} height={20} alt={item.alt} />
          <p>{item.displayText}</p>
        </Link>
      ))}
    </div>
  );
}
