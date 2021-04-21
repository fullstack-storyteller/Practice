'use strict';

console.log('************************coming from spread.js*****************');

//spread operators
const array = [7, 8, 9];
const badNewArray = [1, 2, array[0], array[1], array[2]];
console.log('badNewArray', badNewArray);
const goodNewArray = [1, 2, ...array];
console.log('goodNewArray', goodNewArray);
console.log('goodNewArray', ...goodNewArray); //logs the individual elements. it won't display as array

const newMenu = [...restaurant.mainMenu, 'Gnocchi']; //creates a completely new array without changing the old array

console.log(newMenu);

/**
 * Two use cases of spread operator
 * 1. create shallow copies of the array
 * 2. merge two arrays
 *
 */
// 1. create shallow copy - better call it a copy not shallow copy
const mainMenuCopy = [...restaurant.mainMenu, { name: 'manish' }];
console.log('mainMenuCopy', mainMenuCopy);
//check if it creates shallow copies
const shallowCopyOfmainMenuCopy = [...mainMenuCopy];
console.log('shallowCopyOfmainMenuCopy', shallowCopyOfmainMenuCopy); //not actually a shallow copy as I see object is included in the result
shallowCopyOfmainMenuCopy.push(10);
console.log(
  'shallowCopyOfmainMenuCopy after pushing 10',
  shallowCopyOfmainMenuCopy
);
console.log('mainMenuCopy', mainMenuCopy); //after pushing 10 in shallowcopy, this array is not impacted

// 2. Merge two array
const completeMenu = [...restaurant.starterMenu, ...restaurant.mainMenu];
console.log('completeMenu', completeMenu);

//IMPORTANT
//spread operator (...) works on all iterables, i.e. string array maps or sets but not objects
// spread means separating the supplied iterable with comma and passing it
console.log(...'manish'); //works like charm on string too

// const ingredients = [
//   prompt('Enter ingredient number 1'),
//   prompt('Enter ingredient number 2'),
//   prompt('Enter ingredient number 3'),
// ];

//old way
// console.log(restaurant.orderPasta(ingredients[0],ingredients[1], ingredients[2])); // old way of passing the ingredients

//new way
// console.log(restaurant.orderPasta(...ingredients));

//IMPORTANT
//Since ES2018, spread operators also works on object even though objects are not iterable

const newRestaurant = {
  foundedIn: 1998,
  ...restaurant,
  founder: 'Manish Kumar',
};
console.log(newRestaurant);

//IMPORTANT in previous section we saw shallow copy using oject.assign. we must use the spread operator to main deep copies

const veryNewRestaurant = { ...restaurant };
veryNewRestaurant.name = 'this name is not same as restaurant object.';
console.log(veryNewRestaurant.name, restaurant.name);
