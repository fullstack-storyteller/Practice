'use strict';

console.log(
  '************************coming from 8CodingChallenge2.js*****************'
);

//using game variable from coding challenge 1

for (const [id, val] of game.scored.entries()) {
  console.log(`Goal ${id + 1}: ${val}`);
}

let sumVarAvg = 0;
for (const [, odds] of Object.entries(game.odds)) {
  //game.odds is not iterable but Object.entires(game.odds) is
  sumVarAvg += odds;
}
console.log(sumVarAvg / Object.entries(game.odds).length); //nice

for (const [val, odds] of Object.entries(game.odds)) {
  console.log(
    `Odds of ${game?.[val] ? 'victory of' : 'draw'} ${
      game?.[val] ?? ''
    }: ${odds}`
  );
}

const scorers = {};
for (const vl of game.scored) {
  scorers[vl] ? scorers[vl]++ : (scorers[vl] = 1);
}
console.log(scorers);
