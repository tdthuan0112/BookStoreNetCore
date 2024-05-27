import moment from "moment";
import {
  FAILED_STATUS,
  NORMAL_STATUS,
  PENDING_STATUS,
  SUCCESS_STATUS,
} from "../constant/constantCssName";
import { GENDER_TYPES } from "../constant/constantType";

export function isNullOrUndefined(value) {
  return [null, undefined].indexOf(value) !== -1;
}

export function isEmptyOrNull(value) {
  return ["", [], null, undefined].indexOf(value) !== -1;
}

export function isType(value, type) {
  return typeof value === type;
}

export function isEmptyObject(value) {
  return Object.keys(value).length === 0;
}

export function isArrayHasAnyElements(array = []) {
  return Array.isArray(array) === true && array.length > 0;
}

export function isHasError(code) {
  return code !== 0;
}

export function isArrayContainValue(array, value) {
  return array.indexOf(value) >= 0;
}

export function capitalizeFirstLetter(value) {
  if (value?.length === 0) {
    return "";
  }

  return value.charAt(0).toUpperCase() + value.slice(1);
}

export function transfomDateValue(value) {
  const VALUE = new Date(value);
  var date = VALUE.getDate();
  var month = [
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December",
  ][VALUE.getMonth()];
  var year = VALUE.getFullYear();
  return `${date}/${month}/${year}`;
}

export function transformDateTimeValue(value) {
  var returnValue = moment(new Date(value));
  return returnValue.format("h:mm:ss a, DD/MM/YYYY");
}

export function getCssOrderStatus(orderStatus) {
  switch (orderStatus) {
    case "NORMAL":
      return NORMAL_STATUS;
    case "FAILED":
      return FAILED_STATUS;
    case "SUCCESS":
      return SUCCESS_STATUS;
    case "PENDING":
      return PENDING_STATUS;
  }
}

export function getGenderById(id) {
  switch (id) {
    case -1:
      return GENDER_TYPES.Undefined.name;
    case 0:
      return GENDER_TYPES.Female.name;
    case 1:
      return GENDER_TYPES.Male.name;
  }
}
