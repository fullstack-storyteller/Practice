const EventEmitter = require('events');
// notice the naming convention here 'Event Emitter' is a class

const emitter = new EventEmitter();
// creating the object

emitter.on('messageLogged', function(arg){
    console.log('Listener Called', arg);
});
//register a listner, it will contain a callback function 

emitter.emit('messageLogged' );
// making a noise using - signalling or raising an event
// emit() method must be called after registering a listener, common sense
// if there is no one to listen to somethin, what good is the noise

emitter.emit('messageLogged', {id:1, url: 'https://facebook.com'});
// we can also send additional values or parameter while raising an event
// a good practice is to do it using a object or json for 
// better readability

// you can define listener in one file/module and then export it
// in other module you can simply emit / signal the event if needed with an argument.
// Just like github/practice/node/app2.js, and github/practice/node/app3.js