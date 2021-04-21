console.log("************************************************************");

console.log("this is coming from the 1JSBeginning.js file");
console.log(
  "This is coming from a external javascript file imported into index.html"
);

console.log(40 + 78 - 45);
// alert('Hi, Man!')
console.log("manish" + 1);
console.log(1 + "manish");
console.log(2 + 1);
console.log("2" + 1);
console.log(1 + "2");
console.log("2" + "4");

let myname = "Manish";
//console.log(myName); //reference error
console.log(myname);

myname = "Manish1"; //the value of variables defined with let can be changed
console.log("dynamic typing example below");
console.log(typeof myname);

myname = 20;
console.log(typeof myname);
// let 3year='Manish'
// console.log(3year);
//this gives an syntax error

//let new = 'myname'; // unexpected token error

let _m = "manish"; //allowed
let $m = "manish"; //allowed
console.log(_m + $m);
let my$name = "manish"; //allowed
console.log(my$name);
//let my&name='manish' // not allowed

//DON'T START VARIABLE NAME WITH CAPITAL LETTER. THEY ARE RESERVED FOR OOPS IN JAVASCRIPT

const PI = 3.142; // by convention use const and capital letter for constants
console.log(PI);

//lastly always give your variables proper name

let javaScriptIsFun = true;
console.log(typeof javaScriptIsFun);
console.log(typeof 23);
console.log(typeof "manish");
console.log(typeof 2.34);
console.log(typeof { javaScriptIsFun });

console.log("Undefined value below: ");
let manish;
console.log(manish); //value is undefined
console.log(typeof manish); // type of the value is also undefined
console.log(manish + 1); //NaNnot a number
console.log(manish + "manish"); //here undefined acts as string
console.log("MANISH" + manish); //here undefined acts as string
console.log(manish + 1.23); //NaN
//assign value of undefined to number
console.log("value of undefined to number");
manish = 1;
console.log(manish); //value is undefined
console.log(typeof manish); // type of the value is also undefined

//null
console.log("working with null");
console.log(typeof null); //return object. this is a bug in javascript but it has not been fixed due to legacy reasons. Ideally it should return null similar to undefined
console.log(null + 1); //gives 1
console.log(1 + null); //gives 1
console.log(null + null); //gives 0
console.log(null - null); //gives 0
console.log(null / null); //gives NaN
console.log(null * null); //gives 0
console.log(null + "manish"); //gives nullmanish
console.log("manish" + null); //gives manishnull
