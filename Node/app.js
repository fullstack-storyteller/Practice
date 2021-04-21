// var logger=require('./app1.js')
//it would be better if while importing we use, the const keyword

const logger=require('./app1.js') // this is when export is done as object

logger('test message');//when exported as method we can use as this.

// logger =1 //this will through an error at compile time.

// or
// var logger=require('./app1') 
// Node automatically assumes the .js extension

// or
// var logger=require('./Subfolder/app1') 
// if the file/module was in a subfolder

// or
// var logger=require('../app1') 
// if the module was in parent folder


// Note: by using const, you can avoid assigning incorect values
// to your imported variables.
console.log(logger);

function sayHello(name){
    console.log('Hello '+name)
}

sayHello('Manish')
//console.log(window)

var message="";
console.log(global.message); //undefined

