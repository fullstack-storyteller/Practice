'use strict';

console.log(
  '************************coming from 5CodingChallenge1.js*****************'
);

const game = {
  team1: 'Bayern Munich',
  team2: 'Borrussia Dortmund',
  players: [
    [
      'Neuer',
      'Pavard',
      'Martinez',
      'Alaba',
      'Davies',
      'Kimmich',
      'Goretzka',
      'Coman',
      'Muller',
      'Gnarby',
      'Lewandowski',
    ],
    [
      'Burki',
      'Schulz',
      'Hummels',
      'Akanji',
      'Hakimi',
      'Weigl',
      'Witsel',
      'Hazard',
      'Brandt',
      'Sancho',
      'Gotze',
    ],
  ],
  score: '4:0',
  scored: ['Lewandowski', 'Gnarby', 'Lewandowski', 'Hummels'],
  date: 'Nov 9th, 2037',
  odds: {
    team1: 1.33,
    x: 3.25,
    team2: 6.5,
  },
  printGoals: function (...playersList) {
    console.log(...playersList, playersList.length);
  },
};

const players1 = [...game.players[0]];
const players2 = [...game.players[1]];
console.log(players1);
console.log(players2);
const [gk, ...fieldPlayers] = [...players1];
console.log(gk);
console.log(fieldPlayers);

const allPlayers = [...players1, ...players2];
console.log(allPlayers);

const players1Final = [...players1, 'Thiago', 'Coutinho', 'Perisic'];
console.log(players1Final);

const { team1, x: draw, team2 } = { ...game.odds };
console.log(team1, draw, team2);

console.log(game.printGoals('Davies', 'Muller', 'Lewandowski', 'Kimmich'));
console.log(game.printGoals(...game.scored));

team1 < team2 && console.log('team1 is more likely to win');
team1 > team2 && console.log('team1 is more likely to win');
