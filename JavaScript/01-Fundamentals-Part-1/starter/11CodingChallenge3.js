console.log("************************************************************");
console.log("This is coming from 11CodingChallenge3.js file");
let dolphins1 = 96,
  dolphins2 = 108,
  dolphins3 = 89;
let koalas1 = 88,
  koalas2 = 91,
  koalas3 = 110;

let dolphinAvg = (dolphins1 + dolphins2 + dolphins3) / 3;
let koalasAvg = (koalas1 + koalas2 + koalas3) / 3;
if (koalasAvg > dolphinAvg) console.log("Winner is: Koalas");
else if (koalasAvg < dolphinAvg) console.log("Winner is: Dolphins");
else console.log("It's a draw");

(dolphins1 = 97), (dolphins2 = 112), (dolphins3 = 101);
(koalas1 = 109), (koalas2 = 95), (koalas3 = 123);

dolphinAvg = (dolphins1 + dolphins2 + dolphins3) / 3;
koalasAvg = (koalas1 + koalas2 + koalas3) / 3;
if (koalasAvg > dolphinAvg && koalasAvg >= 100)
  console.log("Winner is: Koalas");
else if (koalasAvg < dolphinAvg && dolphinAvg >= 100)
  console.log("Winner is: Dolphins");
else console.log("It's a draw");

(dolphins1 = 97), (dolphins2 = 112), (dolphins3 = 101);
(koalas1 = 109), (koalas2 = 95), (koalas3 = 106);

dolphinAvg = (dolphins1 + dolphins2 + dolphins3) / 3;
koalasAvg = (koalas1 + koalas2 + koalas3) / 3;
if (koalasAvg > dolphinAvg && koalasAvg >= 100)
  console.log("Winner is: Koalas");
else if (koalasAvg < dolphinAvg && dolphinAvg >= 100)
  console.log("Winner is: Dolphins");
else if (koalasAvg === dolphinAvg && koalasAvg >= 100)
  console.log("It's a draw");
else console.log("no one wins the trophy.");
