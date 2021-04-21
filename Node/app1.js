// console.log(module)

var url='http://mylogger.io/log';
function log(message){
    //send an Http request.
    console.log(message)
}

// both these members are local / private to this module app1.js

// module.exports.log=log; // export as object
module.exports=log; // exporting a single functions

// you can also change the name with which you are exporting
// module.exports.endPoint=url;

// console.log(module);