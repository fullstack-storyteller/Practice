//3FirstClassOrHigherOrderFuncs.js
'use strict';
console.log(
  '*********************Script: 3FirstClassOrHigherOrderFuncs.js***********************'
);

/**NOTE IMPORTANT FIRST CLASS FUNCTIONS
 * JavaScript treats functions as first class citizens
 * This means that functions are simply values
 * Functions are just another "type" of object
 *
 * we can store functions in variables or properties
 * we can pass functions as arguments to OTHER functions
 *
 * we can even return functions from other functions
 * we can call methods on functions
 */

/**NOTE IMPORTANT HIGHER ORDER FUNCTIONS
 *
 * A function that receives another function as an argument, that
 * returns a new functin or both
 *
 * this is only possible becasue if first class functions
 * Ex. btn.addEventListener('click', greet);
 * addEventListener -> higher order
 * greet -> callback function
 *
 * Ex: function count(){
 * let counter=0;
 * return function(){
 * counter++;};
 * }
 *
 * */

const oneWord = function (str) {
  return str.replace(/ /g, '').toLowerCase();
};

const upperFirstWord = function (str) {
  const [FIRST, ...others] = str.split(' ');
  return [FIRST.toUpperCase(), ...others].join(' ');
};

//higher order function
const transformer = function (str, fn) {
  console.log('Original string:', str);
  console.log('transformed string:', fn(str));
  console.log('transformed by:', fn.name); //returns function name
};

transformer('JavaScript is the best', upperFirstWord);
transformer('JavaScript is the best', oneWord);

const high5 = () => {
  console.log('👋');
};
document.body.addEventListener('click', high5);

['manish', 'archana', 'blank'].forEach(high5); //call high5 for each element of the array
