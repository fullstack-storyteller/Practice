"use strict";
console.log("***This is coming from 6CodingChallenge1.js file***");

const calcAverage = (score1, score2, score3) => {
  return (score1 + score2 + score3) / 3;
};
console.log("Data 1");
let avgDolphins = calcAverage(44, 23, 71);
let avgKoalas = calcAverage(65, 54, 49);
const checkWinner = (avgDolphins, avgKoalas) => {
  if (avgDolphins >= 2 * avgKoalas) {
    console.log(`Doplhins win ${avgDolphins} vs. ${avgKoalas}`);
  } else if (avgKoalas >= 2 * avgDolphins) {
    console.log(`Koalas win ${avgKoalas} vs. ${avgDolphins}`);
  } else {
    console.log(`Nobody wins.`);
  }
};

checkWinner(avgDolphins, avgKoalas);

console.log("Data 2");
avgDolphins = calcAverage(85, 54, 41);
avgKoalas = calcAverage(23, 34, 27);

checkWinner(avgDolphins, avgKoalas);
