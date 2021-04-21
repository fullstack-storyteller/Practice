// Remember, we're gonna use strict mode in all scripts now!
"use strict";
console.log("Manish kumar");
const temperture = [3, -2, -6, -1, "error", 9, 13, 17, 15, 14, 9, 5];
const temperture1 = [-12, -6, -1, "error", 9, 13, 17, 15, 14, 9, 5];

/* TODO
ignore error value
find min
find max
return amplitude
 */

const calcAmp = (arr) => {
  let max = arr[0],
    min = arr[0];
  for (let i = 0; i < arr.length; i++) {
    if (typeof arr[i] === "number") {
      if (min > arr[i]) min = arr[i];
      if (max < arr[i]) max = arr[i];
    }
  }
  return max - min;
};
console.log("temperature", temperture);
console.log("calcAmp(temperture)", calcAmp(temperture));

/**TODO
 * Merge two input array inputs
 */

const calcAmp1 = (arr1, arr2) => {
  const arr = arr1.concat(arr2);
  let max = arr[0],
    min = arr[0];
  for (let i = 0; i < arr.length; i++) {
    if (typeof arr[i] === "number") {
      if (min > arr[i]) min = arr[i];
      if (max < arr[i]) max = arr[i];
    }
  }
  return max - min;
};
console.log("temperature", temperture);
console.log("temperature", temperture1);
console.log(
  "calcAmp1(temperture, temperature1)",
  calcAmp1(temperture, temperture1)
);
