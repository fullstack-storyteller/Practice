'use strict';

console.log('************************coming from rest.js*****************');

/**
 * while spread is used to unpack an iterable or an object
 * rest is just the opposite
 */
//the below: SPREAD operation because on the right side of =

const arr1 = [1, 2, ...[3, 4]];
console.log(arr1);

//the below: REST operation because on the left side of =
const [d, e, ...others] = arr1;
console.log(d, e, others);

//another example
const [pz, , ri, ...otherFoods] = [
  ...restaurant.mainMenu,
  ...restaurant.starterMenu,
];

console.log(pz, ri, otherFoods); //otherFoods collectsall the rest of the element except for the skipped element as it was skipped before REST came into picture
//IMPORTANT: REST element  must be the last element because it collect all the remaining

const { s, ...weekdays } = restaurant.openingHours;
console.log(s, weekdays); //s is undefined, because there is no property name s in restaurant.openingHours object
const { sat, ...weekdays1 } = restaurant.openingHours;
console.log(sat, weekdays1); //sat property is there. so we removed it, then whatever remaining come into the rest element
//NOTE: if order doesn't matter in object, so if an element is removed using someother way, it will not be included in rest element

//working with rest element and functions
const add = function (...number) {
  //rest here, contract here
  console.log(number); // prints the number array in console because the separate arguments have been condensed into an array named numbers
  let sum = 0;
  for (let i = 0; i < number.length; i++) sum += number[i];
  return sum;
};
console.log(add(1, 3));
console.log(add(3, 4, 5, 6));
console.log(add(12, 45, 23, 4, 6, 9));

const arrr = [12, 45, 23, 4, 6, 10];
console.log(add(...arrr)); //spread here, expand here

console.log(restaurant.orderPizza('mushroom', 'olives', 'peperoni', 'chicken'));

console.log(restaurant.orderPizza('mushroom'));
