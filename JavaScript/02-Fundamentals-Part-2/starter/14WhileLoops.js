"use strict";
console.log("***This is coming from 14WhileLoops.js file***");
for (let i = 0; i < 10; i++) {
  console.log(`FOR: Lifting Weights ${i + 1}`);
}

let rep = 1;
while (rep <= 10) {
  console.log(`WHILE: Lifting Weights ${rep}`);
  rep++;
}

let dice = Math.trunc(Math.random() * 6) + 1;
console.log("Random Number:", dice);

while (dice !== 6) {
  console.log("You rolled:", dice);
  if (dice === 6) console.log("game is about to end");
  else console.log("game will continue");
  dice = Math.trunc(Math.random() * 6) + 1;
}
console.log("Final Random Number:", dice);
