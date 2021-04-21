console.log("************************************************************");

console.log("This is coming from 8TypeConversionAndCoercion.js file");

console.log(
  "Type conversion is done explicitly(mannually) in JavaScript, where explicitly change the type of a value"
);
console.log(
  "Type coercion is done implicitly(automatically and hidden from us) in JavaScript, where it implicitly changes the type of a value"
);

//type conversion
const inputYear = "1996";
console.log(Number(inputYear), inputYear);
console.log("inputYear+18 = " + (inputYear + 18)); //199618
console.log("Number(inputYear)+18 = " + (Number(inputYear) + 18)); //2014

console.log("Number('Manish') is " + Number("Manish"));
console.log("typeof NaN is " + typeof NaN); //number-this is very interesting, as it is an INVALID NUMBER

console.log(String(23), 23); //number to string
//we can convert a number to a boolean but we can't convert anything to undefined

//type coercion
console.log("Type Coercion:", "I'm " + 23 + " years old!");
console.log("Type Coercion: 23 - '10' - 3 =", 23 - "10" - 3); //10
console.log("'23' * '2' =", "23" * "2"); //46
console.log("'23' / '2' =", "23" / "2"); //11.5
console.log("'23' > '2' =", "23" > "2"); //true
console.log("'23' + '2' =", "23" + "2"); //232

//let guess
let n = "1" + 1;
n = n - 1;
console.log("answer of the guessing game:", n);

console.log("2+3+4+'5' =", 2 + 3 + 4 + "5"); //95
console.log("2+3+4-'5' =", 2 + 3 + 4 - "5"); //4
console.log("'10'-'4'-'3'-2+'5' =", "10" - "4" - "3" - 2 + "5"); //4

//Falsy values: JavaScript has 5 Falsy values
console.log(
  "Falsy values is Javascript: 0, '', undefined, null, NaN and false"
);
// everthing else is a truthy value
console.log("Boolean(0):", Boolean(0)); //false
console.log("Boolean(''):", Boolean("")); //false
console.log("Boolean(undefined):", Boolean(undefined)); //false
console.log("Boolean(NaN):", Boolean(NaN)); //false
console.log("Boolean(null):", Boolean(null)); //false
console.log("Boolean(23):", Boolean(23)); //true
console.log("Boolean('Manish'):", Boolean("Manish")); //true
console.log("Boolean({}):", Boolean({})); //empty object is also a truthy value

const money = 0;
if (money) {
  //this is type coerced to Boolean
  console.log("Don't spend it all..");
} else {
  console.log("You should get a job.");
}

let height; //currently undefined
if (height) {
  console.log("Yay! Height is defined");
} else {
  console.log("Height is not defined or undefined");
}
