//activate strict mode
//this can be done for an entire script, only for a specific function or a specific block
'use strict'; //-> if commented, i can't drive -in console

//strict mode makes it easier to avoid bugs.

let hasDriversLicense = false;
const passTest = true;
// if (passTest) hasDriverLicense = true; //wrote incorrect variable name to check if strict mode is working
//strict mode will throws a error in console saying the varible is not defined

if (passTest) hasDriversLicense = true;
if (hasDriversLicense) console.log('I can dirve');
else console.log("I can't dirve");

//const interface = "Audio";
//strict mode throws error  as Unexpected strict mode reserved word
console.log();
