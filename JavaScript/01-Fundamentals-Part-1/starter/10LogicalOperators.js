console.log("***********************************************************");
console.log("This is coming from 10LogicalOperators.js file");

let hasDriversLicense = true;
let hasGoodVision = true;
console.log(
  "hasDriversLicense && hasGoodVision ->",
  hasDriversLicense && hasGoodVision
);

hasDriversLicense = false;
console.log(
  "hasDriversLicense && hasGoodVision ->",
  hasDriversLicense && hasGoodVision
);

console.log(
  "hasDriversLicense || hasGoodVision ->",
  hasDriversLicense || hasGoodVision
);

hasGoodVision = false;

console.log(
  "hasDriversLicense || hasGoodVision ->",
  hasDriversLicense || hasGoodVision
);

console.log("!hasGoodVision ->", !hasGoodVision);
