'use strict';

console.log(
  '************************coming from 7OptionalChaining.js*****************'
);
//IMPORTANT this was introduced in ES2020
//optional chaining help avoid errors
//see the below scenario
// if (restaurant.openingHours && restaurant.openingHours.mon.open)
//   //Cannot read property 'open' of undefined
//   console.log(restaurant.openingHours.mon.open);
// //no output

// if (restaurant.openingHours && restaurant.openingHours.fri.open)
//   //Cannot read property 'open' of undefined
//   console.log(restaurant.openingHours.mon.open);

//optional chaining - checks if the value or element on the left of the ? exists, only then, it will go and loog for its child properties
console.log(restaurant.openingHours.mon?.open); //returns undefined
console.log(restaurant.openingHours.fri?.open); //returns 11
//no error
//opetional chaining will work to avoid nullish value undefined and null
//if the value is '' or false, it will not come up to save the day

// we can have multiple such optional chaining
console.log(restaurant.openingHours?.fri?.open); //11

//practical application
const days = ['mon', 'tue', 'wed', 'thu', 'fri', 'sat', 'sun'];
for (const day of days) {
  //   console.log(typeof day);
  console.log(day);
  console.log(restaurant.openingHours[day]?.open ?? 'closed'); //NOTE: how to apply nullish operator from es2020
  //we could have used || but it will think zero has valid scenario we only need to do something if the ata is null
}

//NOTE: how to use methods with optional chaining
console.log(restaurant.order?.(0, 1) ?? "Method doesn't not existing"); //method named order exists
console.log(restaurant.orderMe?.(0, 1) ?? "Method doesn't not existing"); //method named order doesn't exists -> undefined

//NOTE: how does optional chaining work with arrays
const users = [{ name: 'Manish', email: 'manish.kumar7@aig.com' }];
console.log(users[0]?.name ?? 'User array is empty!!');

//IMPORTANT : the below is a good question
const f1 = () => {
  const ax = 'bar';
  this.f2 = f2; //this will add f2 function to windows object
  this.f2(); //here undefined wil be returned as 'a' exists in the window object
  console.log(this); //window
};
const f2 = () => {
  console.log(this.ax);
  //   console.log(ax); //ax is not defnied
};
f1();

//NOTE looping over objects
//key / properties name
for (const day of Object.keys(restaurant.openingHours)) {
  console.log(day);
}
//values
for (const day of Object.values(restaurant.openingHours)) {
  console.log(day);
}

//entries keys+values
//it won't work the same way it worked on array, where you can call arrayName.entires.
//here you should use Object.entries like below
for (const day of Object.entries(restaurant.openingHours)) {
  console.log(day[0], day[1]);
}
//doing the same using destructuring
for (const [x, { open: o, close: c }] of Object.entries(
  restaurant.openingHours
)) {
  console.log(x, o, c);
}
