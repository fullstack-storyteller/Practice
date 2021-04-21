'use strict';

//select every thing that we need
const modal = document.querySelector('.modal');
const overlay = document.querySelector('.overlay');
const btnCloseModal = document.querySelector('.close-modal');
// const btnOpenModal = document.querySelector('.show-modal');
// this onle selects the first matching element of that class
const btnOpenModal = document.querySelectorAll('.show-modal');
const closeModal = function () {
  //console.log(this.className + ' Modal closed!!!'); //this.className gives the name of the class from which the handler is called
  console.log('Modal closed!!!');
  modal.classList.add('hidden');
  overlay.classList.add('hidden');
};
const openModal = function () {
  //console.log(btnOpenModal[i].textContent + ' clicked!!!'); //removed for refactoring the code as 'i' was undefined here
  //remove multiple classes by using something like this modal.classList.remove('hidden', 'another classes');

  modal.classList.remove('hidden');
  overlay.classList.remove('hidden');
  console.log(this.textContent + ' clicked!!!'); //'this' works here
};

console.log(btnOpenModal);
for (let i = 0; i < btnOpenModal.length; i++)
  console.log(btnOpenModal[i].textContent);

for (let i = 0; i < btnOpenModal.length; i++) {
  btnOpenModal[i].addEventListener('click', openModal);
}

btnCloseModal.addEventListener('click', closeModal);
overlay.addEventListener('click', closeModal);
//overlay.addEventListener('click', closeModal());
//don't use parenthesis in the event listener handler because javascrit will execute that method as soon as it reaches it.

//keyboard events are global event
//let's use the esc key to close the modal
document.addEventListener('keydown', keyDownEvent => {
  console.log(keyDownEvent);
  if (keyDownEvent.key === 'Escape' && !modal.classList.contains('hidden'))
    closeModal();
});
