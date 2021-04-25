'use strict';
console.log(
  '*********************Script: defaultParameters.js***********************'
);

const bookings = [];
const createBooking = function (flightNum, numPassengers, price) {
  const booking = { flightNum, numPassengers, price };
  bookings.push(booking);
  console.log(bookings);
};
createBooking(); //if we don't supply anything, one object will be created with  undefined values
createBooking('LA320', 2, 39); //to prevent the above scenario, we can use default paramenters in a function

//before going to the modern way of using default parameters, lets see how we used to do this during es5 era
//see below
const createBookingES5 = function (flightNum, numPassengers, price) {
  flightNum = flightNum || 'LA320';
  numPassengers = numPassengers || 1;
  price = price || 39;
  //but the above three lines are broiler plate lines. so let see how modern way of using default parameters
  const booking = { flightNum, numPassengers, price };
  bookings.push(booking);
  console.log(bookings);
};
createBookingES5(); //sending nothing

const createBookingModern = function (
  flightNum = 'Modern',
  numPassengers = 4,
  price = numPassengers * 39
) {
  const booking = { flightNum, numPassengers, price };
  bookings.push(booking);
  console.log(bookings);
};
createBookingModern();
createBookingModern('LA320', undefined, 23); //to skip assigning any parameter in modern js, just supply undefined
