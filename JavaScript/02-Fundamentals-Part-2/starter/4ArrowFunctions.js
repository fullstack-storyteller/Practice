"use strict";
console.log("***This is coming from 4ArrowFnctions.js file***");
//Arrow function
//remember Arrow functions do not get a 'this' keyword - we will learn it
const calcAge3 = (birthYear) => 2021 - birthYear;
logger(`Age from Arrow Function: ${calcAge3(1994)}`);

const yearsUntillRetirement = (birthYear, firstname) => {
  const age = 2021 - birthYear;
  const retirementTime = 65 - age;
  return `${firstname} has ${retirementTime > 0 ? retirementTime : "retired."}`;
};

logger(
  `${yearsUntillRetirement(1980, "Ramesh")} years remaining until retirement.`
);

logger(
  `${yearsUntillRetirement(1990, "Akila")} years remaining until retirement.`
);

logger(`${yearsUntillRetirement(1953, "Manish")}`);
