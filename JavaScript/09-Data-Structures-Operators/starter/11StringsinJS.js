'use strict';

console.log(
  '************************coming from 11StringsinJS.js*****************'
);

const airline = 'TAP Air Purtogalr';
const plane = 'A320';

//position
console.log(plane[0]);
console.log(plane[2]);
console.log('B360'[3]);

//length
console.log(airline.length);
console.log('B360'.length);

//indexOf and lastIndexOf -NOTE Both of them are case-sensitive
console.log(airline.indexOf('r')); //give only the position of the first occurence
console.log(airline.lastIndexOf('r')); //give only the position of the last occurence

console.log(airline.lastIndexOf('z')); //return -1, as 'z' doesn't exist

//slicing or extracting
console.log(airline.slice(4)); //slices or extracts everything starting from index 4 (including)
//NOTE it doesn't mutate the actual string but it creates new
//IMPORTANT Strings are immutable in javaScript, once created no modification can be done to them. you can create something new from them, but slice, trim operations don't change the original strings
console.log(airline.slice(4, 7)); //length of the new string= end-beginning and start indexe is inclusive but end index is exclusive

console.log(airline.slice(0, airline.indexOf(' '))); //TAP
console.log(airline.slice(airline.lastIndexOf(' '))); //Purtogalr

console.log(airline.slice(-2)); //get from end, NOTE negative indexes start from -1 from the right hand side
console.log(airline.slice(1, -1)); //start from index 1 and goes till last index from last of first index from right, but it doesn't include it, because we know slice method's end index is exclusive.

//practice
const checkMiddleSeat = function (seat) {
  console.log(
    `${seat} is ${
      seat.slice(-1) == 'B' || seat.slice(-1) == 'E'
        ? 'a middle'
        : 'not a middle'
    } seat.`
  );
};
checkMiddleSeat('13B');
checkMiddleSeat('23C');
checkMiddleSeat('3E');
// const fm = () => {
//   console.log(this); //since arrow function don't get their own 'this' keyword they utilize their parents'
// };
// fm();

//NOTE changing the case
console.log(airline.toLowerCase());
console.log(airline.toUpperCase());

const passenger = 'manISh';
console.log(
  passenger.slice(0, 1).toUpperCase() + passenger.toLowerCase().slice(1)
);

const email = 'manish.aec2012@gmail.com';
const inputEmail = '   Manish.AEC2012@GMAIL.COM   \n \t';

const suppliedEmail = inputEmail.toLowerCase().trim(); //NOTE trim removes blank spaces and \n enter or \t tabs
console.log(email === suppliedEmail); //returns true

//IMPORTANT since ES2019, we have trimStart and trimEnd methods to trim start and ends only respectively.

//NOTE Replacing

const priceGB = '278,97&';
const priceUS = priceGB.replace('&', '$').replace(',', '.');
console.log(priceUS);

const annoucement =
  'All passengers, please come to boarding door 23. Boading door 23!';

console.log(annoucement);

console.log(annoucement.replace('door', 'gate')); //replaces only the first occurence of 'door'
console.log(annoucement.replaceAll('door', 'gate')); //replaces all the occurences of 'door'
console.log(annoucement.replace(/door/g, 'gate')); //using regular expressions. g is for replacing all as it becomes global
console.log(annoucement.replace(/door/, 'gate')); //without g flag it only replaces the first occurence.

//IMPORTANT Boolean methods

const plane1 = 'A320Neo';

console.log(plane1.includes('A320')); //true
console.log(plane1.includes('Boeing')); //false

console.log(plane1.startsWith('Air')); //false
console.log(plane1.startsWith('A')); //true
console.log(plane1.startsWith('A32')); //true
console.log(plane1.startsWith('a32')); //false, hence the method is case sensitive

console.log(plane1.endsWith('eo')); //true
console.log(plane1.endsWith('peo')); //false
console.log(plane1.endsWith('neo')); //false
console.log(plane1.endsWith('Neo')); //true, hence this method is case senstive

//NOTE split() and Join

console.log('a+very+nice+string'.split('+')); //returns an array of strings found after separating '+'

const myName = 'Manish Kumar';
console.log(myName.split('')); //supplying an empty string separated all the letters in the myName including the space in an array

console.log(myName.split(' ')); // return array of two strings

const [fname, lname] = myName.split(' ');
const newName = ['Mr.', fname, lname];
console.log(newName.join('')); //return a string without space
console.log(newName.join(' ')); //return a string with space between each word

// capitalize IMPORTANT

const capitalize = function (name) {
  const names = name.split(' ');
  const capitalized = [];
  for (let x of names) {
    //method 1
    // capitalized.push(x[0].toUpperCase() + x.slice(1));

    //method 2
    capitalized.push(x.replace(x[0], x[0].toUpperCase()));
  }
  return capitalized.join(' ');
};
const capitalizeName = 'jessica ann smidth davis';
// const capitalizeName='jessica ann smidth davis';
const capiltalozName = 'jonas schemadtmann';

console.log(capitalize(capitalizeName));
console.log(capitalize(capiltalozName));

// NOTE Padding a string

const msg = 'Go to gate 23';
console.log(msg.padStart(25, '+'));
