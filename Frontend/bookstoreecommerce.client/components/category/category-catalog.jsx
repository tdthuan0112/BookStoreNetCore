"use client";

import Image from "next/image";
import Link from "next/link";

import catalogIcon from "@/assets/img/catalog.png";

import classes from "@/styles/layout/category-catalog.module.css";
import { usePathname } from "next/navigation";
import { Guid } from "js-guid";

export default function CategoryCatalog({ allCategories }) {
  const pathName = usePathname().replace("/", "");

  return (
    <div className={classes.categoryCatalog}>
      <div className={classes.headerCatalog}>
        <Image src={catalogIcon} alt="List Icon" width={24}></Image>
        <h3>Category</h3>
      </div>
      <hr />
      <ul className={classes.categoryList}>
        {allCategories.map((category) => {
          let isActive;
          if (category.url === pathName) isActive = true;
          return (
            <li key={Guid.newGuid()} className={classes.categoryItem}>
              <Link
                href={category.url}
                className={`${classes.categoryName} ${
                  isActive ? classes.active : ""
                }`}
              >
                {category.name}
              </Link>
              <span
                className={`${classes.quantity} ${
                  isActive ? classes.active : ""
                }`}
              >
                {category.quantity}
              </span>
            </li>
          );
        })}
      </ul>
    </div>
  );
}
