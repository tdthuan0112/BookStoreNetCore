"use server";
import { CATEGORY_API } from "@/api";
import { getAdminUserAction } from "./user-actions";
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
  const admin = await getAdminUserAction();
  const modifiedBy = admin.userId;

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
  const admin = await getAdminUserAction();
  const createdBy = admin.userId;

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
