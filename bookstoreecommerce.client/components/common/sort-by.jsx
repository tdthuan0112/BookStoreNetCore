import { SORT_TYPES } from "@/lib/constant/constantType";

import classes from "@/styles/common/sort-by.module.css";
import Link from "next/link";

export default function SortBy() {
  return (
    <div className={classes.sortBy}>
      <h3>Sort by</h3>
      <ul className={classes.sortList}>
        {SORT_TYPES.map((sortItem) => (
          <li className={classes.sortItem} key={sortItem.id}>
            <Link href="/">{sortItem.name}</Link>
          </li>
        ))}
      </ul>
    </div>
  );
}
