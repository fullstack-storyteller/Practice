"use strict";
console.log("***This is coming from 8arrayMethods.js file***");

const names = ["Michael", "Joey", "Ross", "Peter"];
console.log(names);

const newLengthPush = names.push("Chandler"); //adds the new value at the end of the array and return the new length of the array
console.log(names, "new Length:", newLengthPush);

const newLengthUnshift = names.unshift("Monica"); //add the supplied element to the start of the array and returns the new length

console.log(names, "new Length:", newLengthUnshift);

const removedPop = names.pop(); //removes the last element and returns it
console.log(names, "Popped element:", removedPop);

const removedShift = names.shift(); //removes the first element and return it
console.log(names, "Shifted element:", removedShift);

console.log("names array:", names);
console.log(names, 'names.indexOf("Michael"):', names.indexOf("Michael"));
names.push("Michael");
console.log(names, 'names.indexOf("Michael"):', names.indexOf("Michael"));
names.pop(); //removed michael from back
names.shift(); //removed michael from front
console.log(names, 'names.indexOf("Michael"):', names.indexOf("Michael")); //returns -1

console.log(names, 'names.includes("Michael"): ', names.includes("Michael")); //uses strict equality
console.log(names, 'names.includes("Michael"): ', names.includes("Peter"));

names.push("23");
console.log(names, 'names.includes("23"): ', names.includes("23"));
console.log(names, "names.includes(23): ", names.includes(23)); //no type coercion ans 23 is not same as "23". hence include is awesome.
