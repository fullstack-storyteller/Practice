'use strict';
console.log(
  '*********************Script: 2passingArguments.js***********************'
);

const flight = 'LH324'; //passed by value
const manish = {
  name: 'Manish Kumar',
  passport: 1234,
}; //passed by reference, it looks like it but, javaScript doesn't have pass by reference, it passes the reference itself as value
const checkIn = function (flightNum, passenger) {
  flightNum = 'LH999';
  passenger.name = 'Mr. ' + passenger.name;
  if (passenger.passport === 1234) {
    console.log('check In');
  } else {
    console.log('wrong input');
  }
};

checkIn(flight, manish);
console.log(flight); //no change
console.log(manish); //name property gets changed

const newPassport = function (person) {
  person.passport = Math.trunc(Math.random() * 100000);
};
newPassport(manish);
checkIn(flight, manish);
console.log(manish);
