'use strict';

const maximum = 20;
const minimum = 1;
const maxAttempts = 20;
const initialScore = 0;

const getRandomNumber = (max, min) => {
  const num = Math.floor(Math.random() * (max - min + 1)) + min;
  console.log(num);
  return num;
  //both ranges are included
};
const alertMe = (message, lives) => {
  document.querySelector('.number').textContent = secretNumber;
  document.querySelector(
    '.message'
  ).textContent = `😞 GAME OVER!!! Click AGAIN to start over...`;
};

let secretNumber = getRandomNumber(maximum, minimum);
// let score = initialScore;
// let attempts = maxAttempts;

document.querySelector('.attempts').textContent = maxAttempts;
document.querySelector('.score').textContent = initialScore;

//reset game
const resetGame = (hardReset) => {
  //   document.querySelector('.number').style.width = '15rem';
  document.querySelector('.message').textContent = 'Start guessing...';
  secretNumber = getRandomNumber(maximum, minimum);

  if (hardReset) {
    document.querySelector('.number').style.width = '15rem';
    document.querySelector('body').style.backgroundColor = '#222';
    document.querySelector('.score').textContent = initialScore;
    document.querySelector('.attempts').textContent = maxAttempts;
  }
  document.querySelector('.guess').value = '';
  document.querySelector('.number').textContent = '?';
};
document.querySelector('.again').addEventListener('click', function () {
  resetGame(1);
  //   console.log(secretNumber);
});

document.querySelector('.check').addEventListener('click', function () {
  //   alert('check clicked');
  const guessed = Number(document.querySelector('.guess').value);
  //   console.log(guessed);

  const attempts = document.querySelector('.attempts');
  const score = document.querySelector('.score');
  const message = document.querySelector('.message');
  const highScore = document.querySelector('.highscore');
  if (Number(attempts.textContent) > 0) {
    if (guessed === secretNumber) {
      document.querySelector('body').style.backgroundColor = '#60b347';
      document.querySelector('.number').style.width = '30rem'; //while working on css stype in javascript always set the values as string
      document.querySelector('.number').textContent = secretNumber;
      message.textContent = "🤟 You're correct!!!";
      score.textContent = Number(score.textContent) + 2;

      if (Number(highScore.textContent) < Number(score.textContent)) {
        highScore.textContent = score.textContent;
      }
      if (confirm(`You've won!!! Play more...`)) {
        resetGame(0);
      }

      //   resetGame();
    } else {
      message.textContent =
        guessed > secretNumber ? '👆 TOO HIGH!!!' : '👇 TOO LOW!!!';
    }
    // if (guessed > secretNumber) {
    //   message.textContent = '👆 TOO HIGH!!!';
    // }
    // if (guessed < secretNumber) {
    //   message.textContent = '👇 TOO LOW!!!';
    // }

    attempts.textContent = Number(attempts.textContent) - 1;
    if (Number(attempts.textContent) === 0)
      alertMe(score.textContent, attempts.textContent);
  } else {
    attempts.textContent = 0;
    alertMe(score.textContent, attempts.textContent);
  }
});
