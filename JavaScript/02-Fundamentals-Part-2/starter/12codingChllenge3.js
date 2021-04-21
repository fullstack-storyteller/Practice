"use strict";
console.log("***This is coming from 12codingChallenge3.js file***");
const mark = {
  fullName: "Mark Miller",
  mass: 78,
  height: 1.69,
  calcBMI: function () {
    this.BMI = this.mass / this.height ** 2;
    return this.BMI;
  },
};
const john = {
  fullName: "John Smith",
  mass: 92,
  height: 1.95,
  calcBMI: function () {
    this.BMI = this.mass / this.height ** 2;
    return this.BMI;
  },
};

console.log(john.calcBMI(), mark.calcBMI());
//at least call the calcBMI method once
//i can't stress this enough. Without calling this method first, the property BMI will return as 'undefined'

const winner = john.BMI > mark.BMI ? john : mark;
const loser = john.BMI > mark.BMI ? mark : john;
console.log(
  `${winner.fullName}'s BMI (${winner.BMI}) is higher than ${loser.fullName}'s BMI(${loser.BMI})!`
);
console.log("************************************");

if (john.BMI > mark.BMI)
  console.log(
    `${john.fullName}'s BMI (${john.BMI}) is higher than ${mark.fullName}'s BMI(${mark.BMI})!`
  );
else if (mark.BMI > john.BMI)
  console.log(
    `${mark.fullName}'s BMI (${mark.BMI}) is higher than ${john.fullName}'s BMI(${john.BMI})!`
  );
else console.log("Both have same BMIs!!");
