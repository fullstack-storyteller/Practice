console.log("************************************************************");
console.log("this is coming from the 2JSVariables.js file");

//we use the let keyboard to declare variables whose value can be changed later
let num = 30;
console.log("num = " + num);
//its called assigning a variable or mutating the variable
num = 35;
console.log("num = " + num);

//we use the keyword const to declare varible which cannot be changed

const birthYear = 1994;
console.log("birthYear = " + birthYear);
//this variable can not be mutated

// birthYear = 1995; //type Error, assignment to a const error

// we can also no do the below
//const birthYear1;
//gives Missing Initializer in const decalration

// we should completely avoid using 'var'. its an old way of writing JS code
var age = 12;
console.log("var age =" + age);

/*
Note: 
let-> it is block scope
var-> it is function scope
*/

console.log("this is created as a property on the global object");
samplecode = "i'm a property in the global object";
console.log(samplecode);

//samplecode varible is not created in the current scope. Instead JS will create a proerty in the global object.
//avoid this practice too.
