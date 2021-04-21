console.log("************************************************************");

console.log("This is coming from 5StringsAndTemplateStrings.js file");

const firstName = "Manish";
const birthYear1 = 1992;
const job = "Student";
const currentYear = 2021;
const jonas =
  "Normal String: I'm " +
  firstName +
  ", a " +
  (currentYear - birthYear1) +
  " old " +
  job +
  "!";
console.log(jonas);
const jonasNew = `Template Strings(using backticks): I'm ${firstName}, a ${
  currentYear - birthYear1
} old ${job}!`;
console.log(jonasNew);

console.log("new line \n containing normal \n string");
console.log(`new line containing
template string defined using 
backticks. Very cool!`);
