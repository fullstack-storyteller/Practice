"use strict";
console.log("***This is coming from 10javascriptObject.js file***");

//array
const jonasArray = [
  "Jonas",
  "Schedtmann",
  2021 - 2000,
  "teacher",
  ["manish", "ashif", "peter"],
];
//Array stores ordered data-order of elements matters

console.log("jonasArray:", jonasArray);

//object literal notation
const jonasObject = {
  firstName: "Jonas",
  lastName: "Schedtmann",
  age: 2021 - 2000,
  profession: "teacher",
  friends: ["manish", "ashif", "peter"],
};
console.log("jonasObject:", jonasObject);
//objects can stored unordered data using keys/properties-order of data doesn't matter

console.log("jonasObject.lastName:", jonasObject.lastName);
console.log("jonasObject['lastName']:", jonasObject["lastName"]);

const nameKey = "Name";
console.log("jonasObject['first'+nameKey]:", jonasObject["first" + nameKey]);
console.log("jonasObject['last'+nameKey]:", jonasObject["last" + nameKey]);

console.log("jonasObject.type: ", jonasObject.type); //undefied as 'type property is not defined
const option = prompt("Enter which property u want:");
console.log("jonasObject.option: ", jonasObject.option); //undefied
console.log(
  `jonasObject[${option}]: `,
  jonasObject[option] ? jonasObject[option] : "invalid input"
);

console.log("Challenge: ");
console.log(
  `${jonasObject.firstName} has ${jonasObject.friends.length} friends and his best friend is ${jonasObject["friends"][0]}.`
);
