"use strict";
console.log("***This is coming from 13ForLoops.js file***");
console.log("Lifting weights repetition 1");
console.log("Lifting weights repetition 2");
console.log("Lifting weights repetition 3");
console.log("Lifting weights repetition 4");
console.log("Lifting weights repetition 5");
console.log("Lifting weights repetition 6");
console.log("Lifting weights repetition 7");
console.log("Print the same using for loop");
//for loops keep running until the condition is true
for (let rep = 1; rep <= 7; rep++) {
  console.log(`Lifting weights repetition ${rep}`);
}

const jonasArray1 = [
  "Jona",
  "Kuamr",
  2037 - 1991,
  "teacher",
  ["michael", "peter", "steven"],
  "timepass",
];
const types = [];
for (let i = 0; i < jonasArray1.length; i++) {
  console.log(
    `jonasArray1[${i}]: ${
      jonasArray1[i]
    }, typeof jonasArray1[i]: ${typeof jonasArray1[i]} `
  );
  //   typeof[i] = typeof jonasArray1[i];//this is good
  types.push(typeof jonasArray1[i]); //this is also fine
}

console.log("types:", types);

const years1 = [1991, 2012, 2020, 1969];
const ages = [];
for (let i = 0; i < years1.length; i++) ages[i] = 2021 - years1[i];
console.log("years[]=", years1);
console.log("ages[]=", ages);

//continue and break

//continue only skips the current iteration of the loop
//break completely comes out of the loop.

console.log("types:", types);
console.log("------------ONLY STIRNGS------------continue");
for (let i = 0; i < types.length; i++) {
  if (types[i] !== "string") continue;
  console.log(types[i]);
  console.log("*************");
}
console.log("------------ONLY STIRNGS------------break");
for (let i = 0; i < types.length; i++) {
  if (types[i] !== "string") break;
  console.log(types[i]);
  console.log("*************");
}

for (let i = 5; i >= 0; i--) {
  console.log(`Starting exercise --- ${5 - i + 1}`);
  for (let j = 1; j <= 5; j++) {
    console.log(`Repetition # ${j}`);
  }
}
