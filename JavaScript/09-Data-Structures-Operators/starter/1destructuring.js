'use strict';

console.log(
  '************************coming from destructuring.js*****************'
);

const restaurant = {
  name: 'Classico Italiano',
  location: 'Via Angelo Tavanti 23, Firenze, Italy',
  categories: ['Italian', 'Pizzeria', 'Vegetarian', 'Organic'],
  starterMenu: ['Focaccia', 'Bruschetta', 'Garlic Bread', 'Caprese Salad'],
  mainMenu: ['Pizza', 'Pasta', 'Risotto'],

  order: function (mainCourseIndex, starterIndex) {
    return [this.starterMenu[starterIndex], this.mainMenu[mainCourseIndex]];
  },
  openingHours: {
    thu: {
      open: 12,
      close: 22,
    },
    fri: {
      open: 11,
      close: 23,
    },
    sat: {
      open: 0, // Open 24 hours
      close: 24,
    },
  },
  orderDelivery: function ({
    starterIndex = 1,
    mainCourseIndex = 0,
    address,
    time,
    deleiveryPerson = 'to be assigned',
  }) {
    console.log(
      `Order received! ${this.starterMenu[starterIndex]} and ${this.mainMenu[mainCourseIndex]} will be delivered at ${address} by  ${time}.`
    );
    console.log(`Delivery person: ${deleiveryPerson}!!`);
  },
  orderPasta: function (ing1, ing2, ing3) {
    console.log(
      `here is your delicious pasta with ${ing1}, ${ing2} and ${ing3}`
    );
  },

  orderPizza: function (mainIngredient, ...otherToppings) {
    let toppings = '';
    for (let i = 0; i < otherToppings.length; i++)
      toppings +=
        otherToppings[i] + (i == otherToppings.length - 1 ? '' : ', ');
    console.log(
      `Order received!! your ${mainIngredient} pizza, ${
        toppings ? 'with ' + toppings : 'without any toppings'
      } will be delivered shortly`
    );
  },
};

//destructuring an array
const arr = [1, 2, 3];
const a = arr[0];
const b = arr[1];
const c = arr[2];
console.log(arr, a, b, c);

const [x, y, z] = arr;
console.log(arr, x, y, z);

let [m, , n] = arr;
console.log(arr, m, n);

console.log('before', m, n);
[m, n] = [n, m]; //switch
console.log('after', m, n);

console.log('before', m, n);
[m, , n] = [n, , m];
console.log('after', m, n);

console.log(restaurant.order(2, 3));
let [starter, mainCourse] = restaurant.order(2, 3);
console.log(starter, mainCourse);
const nested = [3, 4, [5, 6]];
const [i, , j] = nested;

console.log(j, i);

//destructuring inside destructuring - nested destructuring
const [i1, , [j1, k1]] = nested;
console.log(i1, j1, k1);

const [p, q, r] = [8, 9];
console.log(p, q, r); //r will undefined

//setting default values while destructuring
const [p1 = 1, q1, r1 = 3] = [8, 9];
console.log(p1, q1, r1); //if value not found during destructuring, then default values will be set instead of indefined

/**
 * Object destructring:
 */
const { name, categories, openingHours } = restaurant; //the variable which will store the values from the object after destructuring should have eactly the same name as the object's properties to be extracted.
console.log(name, categories, openingHours);

//if you want variable to have a different name other than object properties
const {
  name: restaurantName,
  openingHours: hours,
  categories: tags,
} = restaurant;

console.log(restaurantName, tags, hours);

//default values
const { menu = [], starterMenu: starters = [] } = restaurant; //menu property is not available in the restaurant object hence default value will come into picture, if no default value is given, then we get 'undefnied'
console.log(menu, starters);

//mutating variables
let m1 = 111;
let m2 = 21;

const obj = { m1: 23, m2: 34 }; //we want to assign m1, m2, which are outside the object, the values which is inside the object

//the below line makes sense but it is incorrect
// {m1, m2}=obj; //Unexpected token '=' error
//this happens because the line is not starting with let const or var, so JavaScript treats them as begining of a block, and we can't assign anything to block
//below code fixes it
console.log('before', m1, m2);
({ m1, m2 } = obj);
console.log('after', m1, m2);

//nested objects
const { fri } = restaurant.openingHours;
console.log(fri); //{open: 11, close: 23}
console.log(fri.open, fri.close); //11 , 23

//we can also do
const {
  fri: { open, close },
} = restaurant.openingHours;
console.log(fri); //{open: 11, close: 23}
console.log(fri.open, fri.close); //11 , 23
console.log(open, close); //11 , 23

//or
const {
  fri: { open: o, close: c1 },
} = restaurant.openingHours;
console.log(o, c1); //11 , 23

//practical application of destructureing
//while calling a function will long list of parameters, we can simpley pass the object and have the function take care of destructuring the object sent as argument
//we won't have to worry about the order of the arguments
//IMPORTANT  We still neeed to make sure the name of the object property is same for destructuring to work properly

console.log(
  restaurant.orderDelivery({
    time: '22:30 pm',
    starterIndex: 3,
    address: 'Viva La Dirt League',
    mainCourseIndex: 2,
    deleiveryPerson: 'manish',
  })
);
console.log(
  restaurant.orderDelivery({
    time: '22:30 pm',
    starterIndex: 3,
    address: 'Viva La Dirt League',
    mainCourseIndex: 2,
  })
);
