'use strict';

console.log(
  '************************coming from nullishvalues.js*****************'
);

//NOTE

/**
 * falsy value: 0, false, undefined, '', null
 * truthy value: true, any number integer except 0
 * nullish value: undefnied, null
 */

let temporary;
const temporary1 = temporary ?? 10; //nullish coalesce operator
console.log('temporary', temporary, 'temporary1', temporary1);
