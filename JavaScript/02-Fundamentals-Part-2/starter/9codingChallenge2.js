"use strict";
console.log("***This is coming from 9CodingChallenge2.js file***");

const calcTip = (bill) => {
  return bill >= 50 && bill <= 300 ? 0.15 * bill : 0.2 * bill;
};

console.log("calcTip(100):", calcTip(100));
const bills = [125, 555, 44];
const tips = new Array(calcTip(bills[0]), calcTip(bills[1]), calcTip(bills[2]));
console.log(bills, tips);
const totals = [bills[0] + tips[0], bills[1] + tips[1], bills[2] + tips[2]];

console.log(totals);
const temp = new Array(3); //[empty × 3]
console.log("temp", temp);
temp[4] = "manish"; //[empty × 4, "manish"]
console.log("temp", temp);
