'use strict';

console.log(
  '************************coming from 10CodingChallenge3.js*****************'
);
const gameEvents = new Map([
  [17, '⚽ GOAL'],
  [36, '🔁 Substitution'],
  [47, '⚽ GOAL'],
  [61, '🔁 Substitution'],
  [64, '🔶 Yellow card'],
  [69, '🔴 Red card'],
  [70, '🔁 Substitution'],
  [72, '🔁 Substitution'],
  [76, '⚽ GOAL'],
  [80, '⚽ GOAL'],
  [92, '🔶 Yellow card'],
]);

const gameEventSet = new Set(gameEvents.values());
let events = [...new Set(gameEvents.values())];
console.log(events);
console.log(
  `An event happened, on an average, every ${90 / gameEvents.size} minutes.`
);
console.log(gameEvents);
gameEvents.delete(64);

console.log(gameEvents);

for (const [x, y] of gameEvents) {
  console.log(`[${x <= 45 ? 'FIRST' : 'SECOND'} HALF] ${x}: ${y}`);
}
console.log(1 + 2 + ' apples ' + [1, 2, 3]);
console.log([1, 2, 3]);
