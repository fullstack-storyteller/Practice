"use strict";
console.log("***This is coming from 5FunctionCallingFunctions.js file***");

function cutFruitPieces(fruits) {
  return fruits * 4;
}

function fruitProcessor(apples, oranges) {
  const applePieces = cutFruitPieces(apples);
  const orangePieces = cutFruitPieces(oranges);

  const juice = `Juice with ${applePieces} pieces of apples and ${orangePieces} pieces of Oranges.`;
  return juice;
}

logger(fruitProcessor(3, 4));
