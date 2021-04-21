// Path Module
const path =require('path'); //Node looks for a builtin module
// require('./path') //node looks for an external module to import

console.log( path.parse(__filename));

// Operating System module
const os =require('os');

var totalmemory=os.totalmem();
var freememory=os.freemem();

console.log('Total memory: ', totalmemory/1024/1024);
//Template string 
//ES6 / ES 2015 : ECMAScript 6
console.log(`Total free memory: ${freememory}`); 
//these are back ticks

// File System Module
const fs=require('fs')
// always use asynchronous method for realtime apps
// because using synchronous method will keep the single thread
// we have in node, busy. this will hinder you from serving more 
// users
const files= fs.readdirSync('./') 
// display all file in the present/current directory
console.log(files);

// asynchronouos functions take two more inputs
// node will call these methods once the execution
// is complete [asynchronous]
// these are called callback method

const filesAsync = fs.readdir('./',function(err, files){
    if(err) console.log('Error', err);
    else console.log('Result', files);
});

const filesAsync1 = fs.readdir('&',function(err, files){
    if(err) console.log('Error', err);
    else console.log('Result', files);
});

