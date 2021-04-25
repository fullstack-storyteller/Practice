//5CallAndApply.js
'use strict';
console.log('*********************5CallAndApply.js***********************');

const lufthansa = {
  airline: 'Lufthansa',
  iataCode: 'LH',
  bookings: [],
  //book: functin(){}
  book(flightNum, name) {
    console.log(
      `${name} booked a seat on ${this.airline} ${this.iataCode}${flightNum}`
    );
    this.bookings.push({ flight: `${this.iataCode}${flightNum}`, name });
  },
};

lufthansa.book(239, 'Manish Kumar');
lufthansa.book(635, 'Manish Kumar1');
console.log(lufthansa.bookings);

const booker = lufthansa.book;
//booker(23, 'manish');
//returns error: Cannot read property 'airline' of undefined
//Why this happened? because of 'this' keyword. when called outside an object 'this' is set to undefnied in strict mode and its set to windows object in unstricted mode

//we must use call or apply methods to use booker functions
//remember functions are special kind of objects in JavaScript

booker.call(lufthansa, 23, 'Archana Kumar');

//NOTE
//We can use this booker method on any object similar to lufthansa.
//we just need to make sure the property name of the new object is same

//IMPORTANT
/**
 * call and apply methods help to ensure that this keyword inside the function is pointing to right object, which is supplied as argument to the call method
 *
 */

//example:
const swiss = {
  airline: 'Swiss',
  iataCode: 'SW',
  bookings: [],
};
booker.call(swiss, 243, 'Archana Verma');
//NOTE: Apply also does the exact same thing but it takes an array for a parameter
booker.apply(swiss, [231, 'Ashish Kumar']);
const eurowings = {
  airline: 'EuroWings',
  iataCode: 'EW',
  bookings: [],
};

const flightData = [243, 'Archana Verma'];
booker.call(eurowings, ...flightData);
booker.apply(eurowings, [231, 'Ashish Kumar']);
