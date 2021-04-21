"use strict";
console.log(
  "***This is coming from 3functionExpressionAndDeclaration.js file***"
);

logger(`Age from declarative functions: ${calcAge1(2000)}`);
//note: declarative functions can be called or invoked before the actual declaration also, but not function expressions

// logger(`Age: ${calcAge2(2000)}`); // thorws error: Cannot access 'calcAge2' before initialization

//function declaration
function calcAge1(birthYear) {
  return 2021 - birthYear;
}

//function expression - Annonymous functions
const calcAge2 = function (birthYear) {
  return 2021 - birthYear;
};
logger(`Age from function expression: ${calcAge2(2001)}`);
/*It is recommended to use function expressions because
it will force us to define the function first before using it. lesser bugs
*/
