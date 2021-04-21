"use strict";
console.log("***This is coming from 15CodingChallenge4.js.js file***");

let bills1 = [22, 295, 176, 440, 37, 105, 10, 1100, 86, 52];
let tips1 = [],
  totals1 = [];

for (let i = 0; i < bills1.length; i++) {
  tips1[i] = calcTip(bills1[i]);
  totals1.push(bills1[i] + tips1[i]);
}

console.log("Tips:", tips1);
console.log("Totals:", totals1);

const calcAverage1 = (arr) => {
  let sum = 0;
  for (let i = 0; i < arr.length; i++) {
    sum += arr[i];
  }
  return sum / arr.length;
};

console.log("calcAverage1(totals1):", calcAverage1(totals1));
