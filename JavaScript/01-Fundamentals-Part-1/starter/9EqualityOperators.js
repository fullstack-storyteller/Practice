console.log("************************************************************");

console.log("This is coming from 9EqualityOperator.js file");

const myage = 18;
if (myage === 18) {
  console.log("You just became an adult!");
}

// === means both sides are exactly same. Its called strict comparison operator

// == mean both are same but it does type coercion, hence it is loose comparison operator

// !== strict inequality
// != loose inequality

console.log(" 18 === 18 ->", 18 === 18);
console.log(" '18' === 18 ->", "18" === 18);
console.log(" 18 == 18 ->", 18 == 18);
console.log(" '18' == 18 ->", "18" == 18);
console.log(" 19 == 18 ->", 19 == 18);

console.log(" 18 !== 19 ->", 18 !== 19);
console.log(" '18' !== 18 ->", "18" !== 18);
console.log(" 18 != 18 ->", 18 != 18);
console.log(" '18' != 18 ->", "18" != 18);
console.log(" 19 != 18 ->", 19 != 18);

//avoid using loose (equality or inequality) operator as much as possible

let favNum = prompt("What's you favourite number?");
console.log("typeof favNum", typeof favNum);

if (favNum == 23) {
  //type coercion will happen as string will get converted to number
  console.log(`${favNum} is a prime number.`);
}
