import classes from "@/styles/common/category-selector.module.css";

import CustomIcon from "@/components/common/custom-icon.jsx";
import { useEffect, useState } from "react";

export default function CategorySelector({ bookCategory = [], allCategories }) {
  const [listCategoryIds, setListCategoryIds] = useState(
    bookCategory.map((x) => x.categoryId)
  );

  function updateListCateIds(payload) {
    console.log(payload);
    if (payload.status) {
      if (listCategoryIds.includes(payload.categoryId)) {
        return;
      } else {
        setListCategoryIds((preValues) => [...preValues, payload.categoryId]);
      }
    } else {
      setListCategoryIds((preValues) =>
        preValues.filter((x) => x !== payload.categoryId)
      );
    }
  }

  return (
    <div className={classes.categorySelector}>
      <input type="hidden" name="listCategoryIds" value={listCategoryIds} />
      {allCategories.map((cate) => {
        const isActive = bookCategory.some(
          (x) => x.categoryId === cate.categoryId
        );
        return (
          <SingleCategorySeletor
            category={cate}
            key={cate.categoryId}
            isActive={isActive}
            updateListCateIds={updateListCateIds}
          />
        );
      })}
    </div>
  );
}

function SingleCategorySeletor({
  category,
  updateListCateIds,
  isActive = false,
}) {
  const [isActiveCate, setIsActiveCate] = useState(isActive);
  function toggleIsActiveCate() {
    setIsActiveCate((prev) => !prev);
  }

  useEffect(() => {
    var payload = {
      categoryId: category.categoryId,
      status: isActiveCate,
    };
    updateListCateIds(payload);
  }, [isActiveCate]);

  return (
    <div
      onClick={toggleIsActiveCate}
      key={category.categoryId}
      className={classes.singleCategory}
    >
      <p className={classes.cateName} cate-id={category.categoryId}>
        {category.name}
      </p>
      <div className={classes.checkboxIcon}>
        <CustomIcon
          icon={
            isActiveCate
              ? "fluent:checkbox-checked-20-filled"
              : "fluent:checkbox-unchecked-20-filled"
          }
          width={24}
          height={24}
        />
        {/* <input
          type="hidden"
          name={category.categoryId}
          defaultValue={isActiveCate}
        ></input> */}
      </div>
    </div>
  );
}
