console.log("************************************************************");

console.log("this is coming from 3JSOperators.js file");

let futureYear = 2037;
const ageManish = futureYear - 1992;
console.log("ageManish =" + ageManish);
const ageManisha = futureYear - 1990;

console.log("ageManisha =" + ageManisha, "ageManish =" + ageManish);

console.log(ageManisha * 2, ageManisha / 2, ageManish ** 3);
//type of is also an operator
console.log("Assignment Ooperator.");
console.log(10 + "10"); //1010
console.log("10" + 10); //1010

//assignment operators
let x = 10;
x += 10;
console.log("x+=10 = " + x);
x -= 1;
console.log("x-=1 = " + x);
x *= 2;
console.log("x*=2 = " + x);
x /= 3;
console.log("x/=3 = " + x);
x++;
console.log("x++ = " + x);
x--;
console.log("x-- = " + x);

//comparison operator
console.log("4>5 =", 4 > 5);
console.log("5>2.4 =", 5 > 2.4);

/*

for operator precedence use:
https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Operator_Precedence

*/
