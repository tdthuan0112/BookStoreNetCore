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
