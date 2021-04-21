'use strict';

console.log(
  '************************coming from 9dataStructure.js*****************'
);
//NOTE: SETS
//Sets are iterable just like array and will hold only unique value
//order of elements in a set i irrelevant
//we can't get data out of set using anyway -> we can't even use the the index of the set because there aren't any

const ordersSet = new Set(['pizza', 'pizza', 'rice', 'dal']); //Set() will require an iterable: supplied array
const ordersSet1 = new Set('manisha'); //Set() will require an iterable: supplied string

console.log('ordersSet', ordersSet);
console.log('ordersSet.size', ordersSet.size);
console.log('ordersSet1', ordersSet1);
console.log("ordersSet1.has('a')", ordersSet1.has('a'));

ordersSet1.add('a'); //no effect as only unique values are present
console.log("ordersSet1 after add('a')", ordersSet1);
ordersSet1.add('p');
console.log("ordersSet1 after add('p')", ordersSet1);
ordersSet1.delete('a');
console.log("ordersSet1 after deleting ('a')", ordersSet1);

ordersSet1.clear(); //delete all the values
console.log('ordersSet1 after deleting all ', ordersSet1);

// only way to loop over sets
for (const order of ordersSet) {
  console.log(order);
}

//NOTE: MAP (as well as set were introduced in ES6)
//map has ke and value pair which are unique
//maps are also iterables
const rest = new Map();

//set methods does two things
//1. add the new value i.e. key value pair to map
//2. return the updated map
rest.set('name', 'Classico Italiano');
rest.set(1, 'Florence, Paris');
console.log(rest.set(1, 'Florence, Paris1')); //nothing happenes if the value part is same, but if its different than the existing value against an existing key the the value gets updated
console.log(rest.set(2, 'hajipur, Bihar'));

//NOTE: since set methods return the updated map, we can even perform  chained set operations
console.log(
  rest
    .set('categories', ['general', 'obc', 'obc', 'ebc'])
    .set('money', 'paisa paisa')
    .set(true, "we're open")
);

//get elements from the maps
//IMPORTANT datatype of the keys of maps matter
console.log(rest.get(true));
console.log(rest.get('categories'));
console.log(rest.get('1')); //this is undefnied, because 1 is present but not '1'
console.log(rest.get(1)); //this is valid
console.log("rest.has('categories')", rest.has('categories')); //check if n element is present

console.log(rest);
rest.delete(true); //delete true key
console.log(rest);

//size of map
console.log('rest.size', rest.size);

rest.clear(); //clear all the values of the map
console.log(rest);

//IMPORTANT
rest.set([1, 2], 'test value'); //the key itself is an array
console.log(rest);

console.log(rest.get([1, 2])); //this will result in undefnied because [1,2] in get is different from [1, 2] in keys
//note these two objects are created separately, so they are stored in memory location separately
//make sure the above scenario works do the below

const arrx = [1, 2];
rest.set(arrx, 'this will work!');
console.log(rest);
console.log(rest.get(arrx)); //this time the arrx variable which is storing the array is same hence it can be used to retrieve values from the maps

//More on Maps

const question = new Map([
  ['question', 'What is the best [rpgramming language in the world?'],
  [1, 'C#'],
  [2, 'C'],
  [3, 'JavaScript'],
  [4, 'Java'],
  ['correct', 3],
  [true, 'Correct 💛'],
  [false, 'Try again!!'],
]);
//the above way is favourable when we are writing the map ourset
//we should however use the set function to write maps programmitically
console.log(question);
//when we use the Object.entries() method on any obejct, this is how it shows up in console i.e. like an array of arrays

//NOTE convert objects to maps using this new trick
const hoursMap = new Map(Object.entries(restaurant.openingHours));
console.log(hoursMap);

for (const [key, val] of question) {
  //we don't need to use Object.entries() here as it is an map
  if (key === 'question') console.log('Question: ', val);

  if (typeof key === 'number') console.log(`Answer ${key}: ${val}`);
}
const Answer = 3; //Number(prompt('Your Answer? '));
console.log('Your Answer', Answer);
console.log(question.get(question.get('correct') === Answer));
//console.log(question[(question['correct'] === Answer]); //this won't work because only in objects we can assign and retrieve properties like that in JavaScript. Not in Maps. use get to retrieve keys in map

//NOTE convert map back to an array (of arrays)
const arrayFromMap = [...question];
console.log(arrayFromMap);
console.log(question.entries());
console.log(question.keys());
console.log(question.values());
