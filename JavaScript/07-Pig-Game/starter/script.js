'use strict';

const winningScore = 100;

// selecting elements
// const score0El = document.querySelector('#score--0');
// const score1El = document.getElementById('score--1');
const diceEl = document.querySelector('.dice');
const buttonNew = document.querySelector('.btn--new');
const buttonRoll = document.querySelector('.btn--roll');
const buttonHold = document.querySelector('.btn--hold');

const currentPlayers = [
  document.querySelector('.player--0'),
  document.querySelector('.player--1'),
];

const currentScores = [
  document.getElementById('current--0'),
  document.getElementById('current--1'),
];

const currentTotalScores = [
  document.querySelector('#score--0'),
  document.getElementById('score--1'),
];

let active = 0;
let playing = true;
const switchActive = () => {
  active = (active + 1) % 2;
};
//make sure the game starts with player 1 as active player
//this can be simply done by defining the player--active class in player 0 div class list

const init = () => {
  //reset state variables
  playing = true;
  currentTotalScores.forEach(x => (x.textContent = 0));
  currentScores.forEach(x => (x.textContent = 0));
  active = 0;

  //reset the look css states
  currentPlayers.forEach(x => x.classList.remove('player--active'));
  currentPlayers.forEach(x => x.classList.remove('player--winner'));
  currentPlayers[active].classList.add('player--active');
  diceEl.classList.add('hidden');
};

//initialize the game
init();

const switchPlayer = () => {
  currentScores.forEach(x => (x.textContent = 0));
  currentPlayers.forEach(x => x.classList.toggle('player--active'));
  switchActive();
};

//roll the dice
buttonRoll.addEventListener('click', function () {
  if (playing) {
    const dice = Math.trunc(Math.random() * 6) + 1;

    diceEl.src = `dice-${dice}.png`;
    diceEl.classList.remove('hidden');

    if (dice !== 1) {
      //add dice to current score
      currentScores[active].textContent =
        Number(currentScores[active].textContent) + dice;
    } else {
      // observeGame();
      switchPlayer();
    }
  }
});

//new game or reset game
buttonNew.addEventListener('click', init);

buttonHold.addEventListener('click', () => {
  if (playing) {
    //update the total score of current active player
    currentTotalScores[active].textContent =
      Number(currentTotalScores[active].textContent) +
      Number(currentScores[active].textContent);

    //reset current score of the active player
    currentScores[active].textContent = 0;
    //check for winner
    if (Number(currentTotalScores[active].textContent) >= winningScore) {
      playing = false;
      currentPlayers.forEach(x => x.classList.remove('player--active'));

      // buttonRoll.classList.add('hidden');
      diceEl.classList.add('hidden');
      // buttonHold.classList.add('hidden');
      currentPlayers[active].classList.add('player--winner');
      // exitGame();
      return;
    }
    //change the active player look
    currentPlayers[active].classList.remove('player--active');

    //change the active player and update its class list
    // active = (active + 1) % 2;
    switchActive();
    currentPlayers[active].classList.add('player--active');
  }
});

//functions
