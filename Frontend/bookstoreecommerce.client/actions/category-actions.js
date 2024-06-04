"use server";
import { CATEGORY_API } from "@/api";
import { getUserDetailAction } from "./user-actions";
import { redirect } from "next/navigation";

export async function getAllCategoriesAction() {
  const response = await CATEGORY_API.getAllCategories();
  return response.data;
}

export async function getAllActiveCategoriesAction() {
  const response = await CATEGORY_API.getAllActiveCategories();
  return response.data;
}

export async function getCategoryDetailByIdAction(categoryId) {
  const response = await CATEGORY_API.getCategoryDetailById(categoryId);
  return response.data;
}

export async function deleteCategoryAction(formData) {
  const categoryId = formData.get("categoryId");
  await CATEGORY_API.deleteCategory(categoryId);
  redirect("/admin/manage-categories");
}

export async function updateCategoryAction(formData) {
  const categoryId = formData.get("categoryId");
  const name = formData.get("name");
  const url = formData.get("url");
  const quantity = formData.get("quantity");
  const isActive = formData.get("isActive");
  const user = await getUserDetailAction();
  const modifiedBy = user.userId;

  const payload = {
    categoryId,
    name,
    url,
    quantity,
    isActive,
    modifiedBy,
  };
  await CATEGORY_API.updateCategory(payload);
  redirect("/admin/manage-categories");
}

export async function addNewCategoryAction(formData) {
  const name = formData.get("name");
  const url = formData.get("url");
  const quantity = formData.get("quantity");
  const isActive = formData.get("isActive");
  const user = await getUserDetailAction();
  const createdBy = user.userId;

  const payload = {
    name,
    url,
    quantity,
    isActive,
    createdBy,
  };
  await CATEGORY_API.addNewCategory(payload);
  redirect("/admin/manage-categories");
}
