// var x=;
// making a syntax error on the first line
// then running it


function logme(message){
    console.log(message);
}

logme(__filename);
logme(__dirname);
module.exports.method=logme;

const EventEmitter =require('events');
const emitter = new EventEmitter();

// register an event listner

emitter.on('logging', (args)=> {
    console.log('logged', args);
});

module.exports.handler=emitter;

console.log(module);