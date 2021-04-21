"use strict";
console.log("***This is coming from 11objectMethods.js file***");
const manishObject = {
  firstName: "Manish",
  lastName: "ScheKumardtmann",
  age: (birthYear) => {
    return 2021 - birthYear;
  }, //this object contains a function expression for property age
  birthYear: 1991,
  hasDriversLicense: true,
  profession: "teacher",
  friends: ["Archana", "ashif", "peter", "jonas"],
};

console.log("manishObject.age(1992):", manishObject.age(1992));
console.log("manishObject['age'](1992):", manishObject["age"](1992));

const manishObject1 = {
  firstName: "Manish",
  lastName: "Kumar",

  // age: ()=> {
  //   console.log(this);
  //   return 2021 - this.birthYear;
  // },
  //the arrow function was not working because 'this' was pointing to window object, but the below works!

  age: function () {
    console.log(this);
    return 2021 - this.birthYear;
  },
  birthYear: 1991,
  hasDriversLicense: true,
  profession: "teacher",
  friends: ["Archana", "ashif", "peter", "jonas"],
};
console.log(manishObject1);
console.log("manishObject1.age():", manishObject1.age());
console.log("manishObject1['age']():", manishObject1["age"]());

const manishObject2 = {
  firstName: "Manish",
  lastName: "Kumar",

  // age: ()=> {
  //   console.log(this);
  //   return 2021 - this.birthYear;
  // },
  //the arrow function was not working because 'this' was pointing to window object, but the below works!

  calcAge: function () {
    console.log(this);
    this.age = 2021 - this.birthYear; //tis will add a new property 'age' after the first calculation, so we don't need to calculate again
    return this.age;
  },
  birthYear: 1992,
  hasDriversLicense: true,
  licenseStatus: function () {
    return this.hasDriversLicense ? "a" : "no";
  },
  profession: "teacher",
  friends: ["Archana", "ashif", "peter", "jonas"],
  getSummary: function () {
    return `${this.firstName} is ${
      this.age
    } years old, and has ${this.licenseStatus()} drivers license.`;
  },
};
console.log(manishObject2);
console.log("manishObject2.calcAge():", manishObject2.calcAge()); //called once, now age property is ready
console.log(manishObject2);
console.log("manishObject2['age']:", manishObject2["age"]);
console.log("manishObject2['age']:", manishObject2.age);

console.log("Challenge: ;");
console.log(
  `${
    manishObject2.firstName
  } is ${manishObject2.calcAge()} years old and he has ${manishObject2.licenseStatus()} drivers License.`
);

console.log(manishObject2.getSummary());

//Arrays are just special kinds of objects
