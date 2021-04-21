"use strict";
console.log("***This is coming from 7Arrays.js file***");
const frient1 = "Manish";
const frient2 = "Akila";
const frient3 = "Ramesh";

const friends = ["Manish", "Ramesh", "Akila"];

console.log(friends);

const years = new Array(1991, 1192, 1993, 1994);
console.log(years);
console.log("years[0] =", years[0]); //array index start from 0
console.log("years[1] =", years[1]);
console.log("years[2] =", years[2]);
console.log("years[3] =", years[3]);
console.log("years[4] =", years[4]); //undefined

console.log("years.length = ", years.length); //gives lenth of the array

console.log("friends[friends.length-1] =", friends[friends.length - 1]); //Akila
friends[friends.length - 1] = "Ajay";
console.log("friends[friends.length-1] =", friends[friends.length - 1]); //Ajay
//only only primitive values are immutable, non primitive values are mutable even when they are defined as const

//though we can't replace the entire array
// friends = ["Bob", "Alice"]; //Assignment to constant variable, so its illegal
const firstName = "Jonas";
const jonas = [firstName, "Kumar", 2037 - 1991, "teacher", friends];
//putting all kinds of values in the in one single array called jonas
console.log(jonas);

const calcDiff = (item) => {
  return 2021 - item;
};
console.log("calcDiff(years)", calcDiff(years)); //return NaN
console.log("calcDiff(years[1])", calcDiff(years[1])); //return 829

//in JavaScripts the Index of Arrays is zero based.
const diffs = [
  calcDiff(years[0]),
  calcDiff(years[1]),
  calcDiff(years[2]),
  calcDiff(years[3]),
  calcDiff(years[4]),
];
console.log(
  "calcDiff(years[0]), calcDiff(years[1]), calcDiff(years[2]),calcDiff(years[3]),calcDiff(years[4]): ",
  diffs
);
