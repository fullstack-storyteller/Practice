'use strict';

console.log(
  '************************coming from 12CodingChallenge4.js*****************'
);

const ta = document.createElement('textarea');
ta.id = 'ta';
const button = document.createElement('button');
button.id = 'btn';
button.textContent = 'clickme!';
button.style.width = 'auto';
document.body.append(button);
document.body.append(ta);

const txtArea = document.getElementById('ta');
const btn = document.getElementById('btn');

btn.addEventListener('click', function () {
  toCamelCase(txtArea.value);
});
// console.log(`${✅}`);
const toCamelCase = function (str) {
  let ix = 1;
  const entered = [...str.split('\n')];
  for (const word of entered) {
    const [xx, yy] = [...word.trim().split('_')];
    console.log(
      `${(
        xx.toLowerCase() +
        yy[0].toUpperCase() +
        yy.slice(1).toLowerCase()
      ).padEnd(16, ' ')}    ${'✅'.repeat(ix++)}`
    );
  }
};
