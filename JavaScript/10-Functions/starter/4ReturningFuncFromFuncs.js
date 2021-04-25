//4ReturningFuncFromFuncs.js
'use strict';
console.log(
  '*********************Script: 4ReturningFuncFromFuncs.js***********************'
);

const greet = function (greeting) {
  return function (name) {
    console.log(`${greeting}, ${name}!`);
  };
};

const greeterHey = greet('Hey');
greeterHey('Jonas');
greeterHey('Steven');

greet('Hello')('Manish');

const greetArrow = greetings => {
  return name => {
    console.log(`${greetings}, ${name}!`);
  };
};
const greetArrowHey = greetArrow('Namaste');
greetArrowHey('JonasByArrow');
greetArrowHey('StevenArrow');

greetArrow('Hello')('ManishArrow');
