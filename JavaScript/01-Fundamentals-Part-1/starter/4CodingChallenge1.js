console.log("************************************************************");

console.log("This is coming from 4CodingChallenge1.js file");

let weightMark = 78,
  weightJohn = 92;
let heightMark = 1.69,
  heightJohn = 1.95;
console.log("case 1");
let bmiJohn = weightJohn / heightJohn ** 2;
console.log("version 1 John's BMI: ", bmiJohn);

let bmiMark = weightMark / heightMark ** 2;
console.log("version 1 Mark's BMI: ", bmiMark);

let markHigherBMI = bmiMark > bmiJohn;
console.log("case 1, version 1:- bmiMark > bmiJohn: ", markHigherBMI);

bmiJohn = weightJohn / (heightJohn * heightJohn);
console.log("version 2 John's BMI: ", bmiJohn);

bmiMark = weightMark / (heightMark * heightMark);
console.log("version 2 Mark's BMI: ", bmiMark);

markHigherBMI = bmiMark > bmiJohn;
console.log("case 1, version 2:- bmiMark > bmiJohn: ", markHigherBMI);

(weightMark = 95), (weightJohn = 85);
(heightMark = 1.88), (heightJohn = 1.76);

console.log("case 2");

bmiJohn = weightJohn / heightJohn ** 2;
console.log("version 1 John's BMI: ", bmiJohn);

bmiMark = weightMark / heightMark ** 2;
console.log("version 1 Mark's BMI: ", bmiMark);

markHigherBMI = bmiMark > bmiJohn;
console.log("case 2, version 1:- bmiMark > bmiJohn: ", markHigherBMI);

bmiJohn = weightJohn / (heightJohn * heightJohn);
console.log("version 2 John's BMI: ", bmiJohn);

bmiMark = weightMark / (heightMark * heightMark);
console.log("version 2 Mark's BMI: ", bmiMark);

markHigherBMI = bmiMark > bmiJohn;
console.log("case 2, version 2:- bmiMark > bmiJohn: ", markHigherBMI);
