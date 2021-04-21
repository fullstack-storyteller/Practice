'use strict';

/**
 *TOPIC
 * Javascript is a high level object oriented multi paradigm programming language
 *
 *Javascript is a high level, prototype based,
 object oriented multiparadigm, interpreted or just in time compiled, dynamic, single threader, garbage colleted programmin with first class functions and a non blocking event loop concurency model
 *
 *the above may be a brief joke but, its kind of the actual definition
 */

// High Level
// Any computer program needs resources.
/**
 * In low level languages developer has to do the managing of
 * the resources himself
 * This is not the case in  high level language
 */

//garbage collection
//cleans the memory so that we don't have to do it ourselves

//Interpreted or just in time compiled, does line by line compiling

//Multi paradigm
// An paradigm is an approach and mindset of structuring code, which will direct your coding style and technique
/**
 * Three popular paradigm are:
 * Procedural Programming -> very linear way of organising code
 *
 * Object oriented Programming -> it is prototype based object
 * oriented approach [Everything except primitive type values like numbers, string, are object in JS]
 *
 * Functional Programming
 *
 * we can also classify paradigms are imperative vs declarative
 *
 */

// JavaScript is a language with a first class functions, which means the functions are considered to be just like any other regular variables.

// we can pass functions into other functions and even return it from other functions

// javaScript is a dynamically typed language. we don't assign the type of variable( i.e. we don't define then but only declare them) when we declare them

//Non Blocking event loop
// concurrency model is how the javascript engine handles multiple tasks happening at the same time
//this is needed because javascript runs in one single thread, so basically it can do only one thing at a time.
//To handle long running tasks
//we can use a event loop

//By using event loop we a take long running tasks execute them in the "background", and puts them back in the main thread once they are finished

//The Javascript Engine and Runtime
//JS Engine is a program that runs JavaScript code
//Example: V8 Engine in chrome and Node

//There are many javaScript engines but
/**
 * Any Javascript Engine always contains a callstack and a heap
 * The callstack is where are code is actually executed using something called an Execution Context
 * Heap is an unstructured memory pool which stores all the objects which an JS application needs
 */

//How javascript code is compiled to machine code?

//Side Note:
//Compilation: Entire code is converted into machine code at once
//and written to a binary file that can be executed by a computer
//[source code] --step 1: compilation--> [Portable file: Machine code] --step 2: execution--> [Program running]

//interpretation: Interpreter runs through the source code and executes line by line
//[Source code] --step 1: execution line by line--> [Program Running]

// JS used to be a purely interpreted language, but problem with interpreted languages is that they are much much slower to run
// Modern JS engine now use a mix between compilation and interpretation, which is called Just-in-time compilation
/**
 * Just-in-time(JIT) compilation: entire code is converted into
 * machine code at once, then executed immediately
 * This means there is no executable file but there is still ahead of time compilation. There is still two steps:
 * [Source Code] --Step 1: Compilation--> [Machine code (no execuatble / portable file)] --Step 2: Execution--> [Program Running]
 */

//Steps is executing a javascript code:
/**
 * As a piece of javascript code enters the engine,
 * 1. Parse the code [read the code] into a data structure Abstract syntax tree (AST)
 *  This works by first splitting up each line of code into pieces that are meaningfull to the language like the const and function keywords
 *  Then saving all these pieces into a treee in a structured way
 *  This steps also checks if there are any syntax errors
 *  The resulting tree will later be used to generate a machine code
 *  The AST is not related to DOM tree in any way
 *
 * 2. After parsing, generated AST is compiled into machine code
 *  This machine code then gets executed right away
 *
 * 3. Execution happens in JS engine's call stack. we will see more about this later
 *
 * Note: First a very unoptimized version of machine code in the begining and it is then executed, while excution various special  thread (apart from the main thread) are running in a engine which keep on optimizing and compiling the machine code and keep replacing the code to achieve further optimization
 *
 */

//JS Runtime ( Browser)
/**
 * It contains all the thing that are needed to run javascript
 *
 * 1. JS Engine [Heap, Call Stack]
 * 2. Web APIs are funcitonalities provided to the JS engine but not part of the javascript language [DOM, Timers, Fetch API, and many more]. JS engines gets access to these functionalites through the global 'windows' object. Hence they are part of javascript runtime not JS engine
 * 3. Callback queue: This is a data structure that contains all the callback functions that are ready to be executed
 *  Ex: callback fucntions from DOM listener onClick, timer, data...
 *
 * So once an event happens, the corresponding callback function is put into the callback queue, then when the callstack is empty the callback function is passed to the stack so that it can be executed
 * This is done using an EVENT LOOP. That's how non blocking is implementated in JS
 *
 * In Node.js js runtime, replace the web api with multiple c++ binding and thread pools
 *
 */

// Execution context (Global and Function)
/**
 * Let's assume compilation is completed
 * 1. Creation of Global Execution Context(GEC) for top level code i.e. the code that is not inside any method
 *
 * Ex:
 *  take a look at the below script
 *
 * const name='Manish';
 * const first=()=>{let a=1; const b=second(7, 9); a=a+b; return a;};
 * function second(x, y){var c=2; return c;}
 * const x=first();
 *
 * In the above script: IMPORTANT
 * GEC is created first with [variables: name, constants: x, functions: first, second ], and only one GEC will be created for a JS program
 * This GEC will be pushed to the callstack
 * for constant x we have a function call, hence a Function Execution Context (FEC) for function 'first' will be created with [ variables: a, constant b]
 * the will again be pushed to the callstack
 * For constant b we have a function call, hence a FEC for function 'second' will be created with [ variable c, array of passed arguments [7, 9] ] and get pushed to the callstack
 * At this point of time, the call stack will look like below:
 *
 * ||                     ||
 * || Second function FEC ||
 * || First function FEC  ||
 * || GEC                 ||
 *  ======================
 * While the Second function FEC is running or executing the execution of GEC and First function FEC will be paused.
 *
 * As soon the second function concluded the "Second function's FEC" will be popped out from the callstack
 * then the "First function's FEC" will be popped
 *
 * And the when all functions are done executing, the engine will basically keep waiting for the callback functions to arrive and then it will execute them
 * callback functions like listeners to user action in DOM will be put in callback queue, and as soon as the callstack is ready i.e. only GEC is present in
 * the callstack, the event loop will start pushing callback functions from callback queue to callstack
 *
 * Note: GEC will only pop out from the callstack when the browser window is closed or program completely concludes
 *
 */

/**
 * Deep Dive into Execution context: IMPORTANT
 * Inside a Execution Context:
 *  1. Variable Environment:
 *      > let, const,and var variables
 *      > Functions
 *      > arguments object (arguments is a keyword)
 * Note: all functions variable will end up in the above variable environment but a function can also access variable which are defined outside of its
 * definition. That's where scope chain comes into picture
 *
 * 2. Scope chain:
 *      It consists of the references to variables that are located outside of the current function
 *      To keep track of this scope chain, it is kept in the execution context of each function
 *
 * 3. The 'this' keyword. Every execution context get this special keyword. We will know more about this later.
 *
 * VERY VERY IMPORTANT 1: Execution context belonging to arrow fucntions DO NOT get their 'arguments' and 'this' keyword. Instead they can use
 * these keywords from their closest regular function parent.
 *
 * VERY VERY IMPORTANT 2: Execution Context will have two phases: creation and execution
 * 1. During creation variable environment is constructed and variables will have values if they are defined in top level code,
 * and function variables will have literall the fucntion code
 * 2. During execution phase all the function will execute and once executed the execution context will be popped.
 *
 */

/**
 * //Scope and Scope Chain
 *  We know that each executing environment has the below:
 *  1. A variable environment [let, const, var methods/function, and arguments]
 *  2. Scope chain for accessing outside variables
 *  3. this keyword
 *
 * SCOPING:-
 * How our program's variables are organized and accessed.
 * Where do variables live? or where can we access a certain variable
 * where not?
 *
 * LEXICAL SCOPING:-
 * Means scoping is controlled by placement of functions and blocks
 * in the code
 *
 * Scope: space or environment in which a certain variable is
 * declared (variable environemnt in case of functions). There is global scope, function scope and block scope
 * For the case of function, scope and variable environment which is stored in the function's execution context is essentially the same.
 *
 * Scope of a variable:
 * Region of our code where a certain variable can be accessed
 *
 */

//IMPORTANT
// Global Scope
/**
 * const me='Manish';
 * const job='teacher';
 * const year=1999;
 *
 * Outside of any function or block
 * Variables declared in the global scope are accessible everywhere
 */

// Function Scope
/**
 *
 * function calcage(Birthyear){
 * const now=2087;
 * return now - Birthyear; }
 *
 * console.log(now); //ReferenceError
 *
 * It is also called local scope
 * Variable are accessible only  inside function, NOT outside
 *
 */

// Block Scope (ES6)
/**
 * if(year>=1981 && year<= 1996){
 * const millenial=true;
 * const food='Avacado toast';
 * }
 * console.log(millenial); //referenceError
 *
 * variable are accessible only inside block (block scoped)
 * HOWEVER this is only applied to 'let' and 'const' variables
 *
 * Functions are also block scopped (only in strict mode)
 */

// The scope chain
//take a look at the below snippet

// const myName = 'Manish';
// function first() {
//   const age = 30;
//   if (age >= 30) {
//     // second(); this is also valid
//     //first(); this is also valid but be careful this will lead to recursion and callstack will overflow
//     const decade = 3;
//     const myName = 'Jonas'; //this will work because here JS engine will not do variable lookup in the scope chain as the variable is available locally
//     console.log('Inside if block -', myName);
//     var millenial = true;
//   }
//   function second() {
//     //first(); this is also valid but be careful this will lead to recursion and callstack will overflow
//     const job = 'teacher';
//     console.log(`${myName} is a ${age}-old ${job}`); //myName will still have Manish, because its different from the myName variable in the if block
//   }
//   if (millenial) console.log('You are a millenial');
//   second();
// }

// first();
// second(); //this is not defined or out of scope because function in es6 are block scope

/**IMPORTANT
 * In the above snippet, the scope chain will be as follows:
 *
 * {Global Scope}: [myName, first()]
 * {'first()' Scope}: [age, first(), second(), {Global Scope}, millenial]
 * {'second()' Scope}: [job, second() {'first()' Scope}]
 * {'if' block Scope}: [decade, second(), first()] <- you might notice why millenial variable is not part of 'if' block, its because its
 *  declared using 'var' keyword, and block scopes don't apply on variables defined with 'var', it becomes a funcition scope
 *
 *
 * This is the chain that's called scope chain
 * The process of finding a varible in the scope chain is called
 * variable lookup
 * {Secon() scope} and {if scope} are sibling scope.
 *
 *IMPORTANT
 * SCOPE CHAIN understandsorder in which the functions are written in the code
 * it has nothing to dow ith the oorder in which these functions are invoked or called.
 *
 */

/**
 * IMPORTANT
 * TEMPORAL DEAD ZONE and Hoisting
 *
 * TEMPORAL DEAD ZONE is the region of the scope in which the varible is defined but can't be used in anyway
 *
 * HOISTING: JS makes sometypes of variables accessible / usable in the code before they are actually declared, i.e., "Variables lifted to the top of their scope" Follow the below though
 *
 * IMPORTANT
 * Behind the scenes, before execution, code is scanned for variables declarations and for each variables a new property is created in the variable environment object
 *
 * function declarations: {Hoisted:true, InitialValue: Actual Function, Scope: Block (in strict mode)[, function(otherwise)]}
 *
 * var variables:{Hoisted:true, InitialValue: Undefined, Scope: function}
 *
 * let and const variables:{Hoisted:false[texhnically, yes, but not in practice as they are in temporal dead zone(TDZ)], InitialValue: <uninitialized>, TDZ, Scope: block}
 *
 * function expressions and arrow functions: {depends if using var or let/const, they will behave how the variables behave in such situation}
 */
//IMPORTANT
// const myName = 'MAnish';
// if (myName === 'MAnish') {
//   console.log(`Manish is a ${job}`); //ReferenceError: Cannot access 'job' before initialization
//   //job is defined but can't be used before it can be initialized
//   console.log(`Manish is a ${job1}`); //manish is a undefined
//   const age = 2037 - 1989;
//   console.log(age);
//   const job = 'teacher'; //before this line job was defined but was in TEMPORAL DEAD ZONE
//   var job1 = 'teacherVar'; //this var variable gets hoisted and initialized to undefined
//   console.log(x); //ReferenceError: x is not defined
// }

//Why hoisting?
/**
 * help in using functions before actual declaration
 * var hoisting is just a byproduct
 */

//Why Temporal Dead Zone
/**
 * Makes it easier to avoid and catch errors: accessing variables before declaration is bad and should be avoided
 * Makes const variables actually work
 */

//IMPORTANT - Practice

// console.log(me); //undefined
// console.log(job); //ReferenceError: Cannot access 'job' before initialization
// console.log(year); //ReferenceError: year is not defined

// var me = 'MANISH';
// let job = 'teacher';
// const year = 1992;

//Function
// console.log(addFunctionDeclaration(2, 3)); //works due to hoisting

// console.log(addFunctionExpression(2, 3)); //ReferenceError: Cannot access 'addFunctionExpression' before initialization; it is defined using const

// console.log(addArrowFunction(2, 3)); //ReferenceError: Cannot access 'addArrowFunction' before initialization; it is defined using const

// console.log(addFunctionUsingVAR(2, 3)); //TypeError: addFunctionUsingVAR is not a function

// function addFunctionDeclaration(a, b) {
//   //this will be hoisted
//   return a + b;
// }
// const addFunctionExpression = function (a, b) {
//   //this will go into TDZ
//   return a + b;
// };

// const addArrowFunction = (a, b) => {
//   //this will go into TDZ
//   return a + b;
// };

// var addFunctionUsingVAR = function (a, b) {
//   //this will not work even though it is defined as var and gets hoisted, because it is undefined
//   //that's because any variable or function defined using var and called before actual decalration, will be set undefined,
//   //so if the variable or function is 'undefnied', how do you expect it to produce an output
//   return a + b;
// };
//console.log(addFunctionUsingVAR(2, 3)); //no errors here

//IMPORTANT
//variables declared using var creates a property by variable name in windows global object
// var x = 1;
// let y = 2;
// const z = 3;

// console.log(x === window.x); //true
// console.log(y === window.y); //false
// console.log(z === window.z); //false

//IMPORTANT

/**
 * This keyword/variable: Special variable that is created for every execution context (every function)
 *
 * Takes the values of (points to) the "owner" of the function in which the 'this' keyword is used.
 *
 * This is NOT static. It depends on how the function is called, and its value is only assigned when the function is actually called, i.e. value of this will
 * be dynamic
 *
 * For example:
 * 1. Method (function attached to a object) ==>> 'this' points to the object that is 'calling' the  method
 * 2. Simple function call (In strict mode)==>> 'this' points to undefined
 * 3. Simple function call (without strict mode)==>> 'this' points to global window object
 * 4. Arrow function ==>> 'this' points to the surrounding function (lexical this). Arrow functions do not get their own 'this' keyword
 * 5. Even listener ==>> 'this' points to the  DOM element that the handler is attached to
 *
 * IMPORTANT NOTE: 'this' doesn't point to the function itself, and also NOT its variable environment
 * 'This' keyword can also be used with NEW, CALL, APPLY, BIND to call function, we will see about this later
 *
 */

// console.log(this); //window object

// const calcAge = function (birthYear) {
//   console.log(2037 - birthYear);
//   console.log(this); //undefined as it is inside a function with no "owner" in strict mode
//   //in unstricted mode this 'this' keyword will point to the windows object
// };
// calcAge(1994);

// const calcArrow = birthYear => {
//   console.log(2021 - birthYear);
//   console.log(this); //window object as this is arrow function and it has no surrounding function
// };
// calcArrow(1994);

// const manish = {
//   year: 1994,
//   calcAgeInsideObject: function () {
//     console.log(2022 - this.year);
//     console.log(this); //points to the object containing the function
//   },
// };

// //IMPORTANT
// manish.calcAgeInsideObject(); //this point to manish object

// const archana = {
//   year: 2017,
// };

// archana.calcAgeInsideObject = manish.calcAgeInsideObject;
// archana.calcAgeInsideObject(); //5 this points to the archana object

//Note:
// const temp = manish.calcAgeInsideObject;
// temp(); //TypeError: Cannot read property 'year' of undefined
////no owner present here for 'temp' variable

//IMPORTANT
// const manish = {
//   firstName: 'Manish',
//   year: 1994,
//   calcAgeInsideObject: function () {
//     console.log(2022 - this.year);
//     console.log(this); //points to the object containing the function
//   },
//   greet: () => {
//     console.log(`Hey, ${this.firstName}!`);
//   },
// };

// manish.greet(); //`Hey, undefined!`
//this keyword used in Arrow functions inside an object literal will not point to the object but global scope or parent function scope
//in our example this.firstName is not present in window object

// IMPORTANT
//Never ever use a arrow funtion in the object literal, you can use a regular annonymous function see below:
// const manish1 = {
//   firstName: 'Manish1',
//   year: 1994,
//   calcAgeInsideObject: function () {
//     console.log(2022 - this.year);
//     console.log(this); //points to the object containing the function
//   },
//   greet: function () {
//     console.log(`Hey, ${this.firstName}!`);
//   },
// };

// manish1.greet(); //Hey, Manish

//IMPORTANT - Question: correct the below code
// const manish1 = {
//   firstName: 'Manish1',
//   year: 1994,
//   calcAgeInsideObject: function () {
//     console.log(2022 - this.year);
//     console.log(this); //points to the object containing the function

//     const functionInsideMethod = function () {
//       console.log(this.year); //erroneous line
//     };
//     functionInsideMethod();
//   },
// };
// manish1.calcAgeInsideObject(); //Cannot read property 'year' of undefined

// //Solution 1
// const manish2 = {
//   firstName: 'Manish1',
//   year: 1994,
//   calcAgeInsideObject: function () {
//     console.log(2022 - this.year);
//     console.log(this); //points to the object containing the function
//     const that = this;
//     const functionInsideMethod = function () {
//       console.log(that.year);
//     };
//     functionInsideMethod();
//   },
// };
// manish2.calcAgeInsideObject(); //Cannot read property 'year' of undefined

// // //Solution 2
// const manish3 = {
//   firstName: 'Manish1',
//   year: 1994,
//   calcAgeInsideObject: function () {
//     console.log(2022 - this.year);
//     console.log(this); //points to the object containing the function

//     const functionInsideMethod = () => {
//       console.log(this.year);
//     };
//     functionInsideMethod();
//   },
// };
// manish3.calcAgeInsideObject(); //the arrow function inside the method will will using 'this' keword of it parent function/method

//IMPORTANT
//Argument keyword in function expressions
//NOTE Arrow functions don't get arguments keyword

// const addMe = function (x, y) {
//   console.log(arguments);
//   return x + y;
// };
// console.log(addMe(3, 5)); //8
// console.log(addMe(4, 5, 5, 6)); //9, no errors
// //you can loop over the arguments array to get more accurate add

//TOPIC Primitive and Object types
//Primitive: [Number, String, Boolean, Undefnied, NULL, Symbol, BigInt] also called primitive types and are stored in callstack(Execution context)
//Objects: [Object literals, Arrays, functions and many more...] also calle reference types and are stored in memory heap

const Person1 = {
  firstName: 'Archana',
  lastName: 'Verma',
  age: 25,
  family: ['Poonam', 'Rajni', 'Manish'],
};
const PersonAfterMarriage = Person1;

// PersonAfterMarriage.lastName = 'Kumar';
// console.log(Person1);
// console.log(PersonAfterMarriage);
//both the last name are changing

const PersonAfterMarriage1 = Object.assign({}, Person1);
PersonAfterMarriage1.lastName = 'Kumar';
console.log(Person1);
console.log(PersonAfterMarriage1);
//now this works but Object.Assign(source, target) only creates a
//shallow copy of the source object, i.e. only the top level properties will be copied
//if we change anythin in the newly created object's array property i.e. family, the change will reflect in both the objects

PersonAfterMarriage1.family.push('Ajay');
console.log(Person1);
console.log(PersonAfterMarriage1);

//to create a deep clone/copy we may need to use some libraries like loadash, we will see them in coming sections
