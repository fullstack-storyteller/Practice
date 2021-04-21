'use strict';

console.log(
  '************************coming from 6ForOfLoops.js*****************'
);

//NOTE: this started in ES6
const myMenu = [...restaurant.starterMenu, ...restaurant.mainMenu];
console.log(myMenu);

//below are basically doing the same thing but just follow how to use for-of loop
for (const x of myMenu) {
  console.log(x);
}

for (const x of myMenu.entries()) {
  console.log(`${x[0]}: ${x[1]}`);
}
for (const [id, desc] of myMenu.entries()) {
  //IMPORTANT
  //destructure the entrie element right away
  console.log(`${id + 1}: ${desc}`);
}
