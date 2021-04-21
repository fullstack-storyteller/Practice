'use strict';
console.log('***This is coming from 2functionInJS.js file***');

//defining a function
function logger(msg) {
  console.log('Logger Manish:', msg);
}
//calling or running or invoking a function
logger(); //no arguments supplied-> undefined
logger(); //since this function doesn't return anything, it means it returns undefined.

// <- variable private to the function i.e parameters
function fruitProcessor(apples, oranges) {
  console.log(`Apples: ${apples}, Oranges: ${oranges}`);
  const juice = `Juice with ${apples} apples and ${oranges} oranges`;
  return juice;
}

logger(fruitProcessor(8, 4)); //<- value supplied to fruit processor function is called arguments
