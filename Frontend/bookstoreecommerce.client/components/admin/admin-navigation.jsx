"use client";

import Link from "next/link";
import Image from "next/image";

import { usePathname } from "next/navigation";

import viewListImg from "@/assets/img/view-list.png";
import bookEditImg from "@/assets/img/book-edit.png";
import userEditImg from "@/assets/img/user-edit.png";
import categoryEditImg from "@/assets/img/category.png";
import classes from "@/styles/common/admin-navigation.module.css";

export default function AdminNavigation() {
  const pathname = usePathname();
  const isManageOrderPage = pathname === "/admin/manage-orders";
  const isManageBookPage = pathname === "/admin/manage-books";
  const isManageUserPage = pathname === "/admin/manage-users";
  const isManageCategoryPage = pathname === "/admin/manage-categories";
  return (
    <div>
      <div>
        <p>Admin Account of</p>
        <p>
          <strong>Thuan Tran</strong>
        </p>
      </div>
      <Link
        href="/admin/manage-orders"
        className={`${classes.navLink} ${
          isManageOrderPage ? classes.activeLink : undefined
        }`}
      >
        <Image src={viewListImg} with={20} height={20} alt="Account Image" />
        <p>Manage Orders</p>
      </Link>
      <Link
        href="/admin/manage-books"
        className={`${classes.navLink} ${
          isManageBookPage ? classes.activeLink : undefined
        }`}
      >
        <Image src={bookEditImg} with={20} height={20} alt="Account Image" />
        <p>Manage Books</p>
      </Link>
      <Link
        href="/admin/manage-users"
        className={`${classes.navLink} ${
          isManageUserPage ? classes.activeLink : undefined
        }`}
      >
        <Image src={userEditImg} with={20} height={20} alt="Account Image" />
        <p>Manage Users</p>
      </Link>
      <Link
        href="/admin/manage-categories"
        className={`${classes.navLink} ${
          isManageCategoryPage ? classes.activeLink : undefined
        }`}
      >
        <Image
          src={categoryEditImg}
          with={20}
          height={20}
          alt="Account Image"
        />
        <p>Manage Categories</p>
      </Link>
    </div>
  );
}
