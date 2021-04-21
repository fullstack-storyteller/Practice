const EventEmitter=require('events');

const url='https://manish.kumar7.com';

class Logger extends EventEmitter{
    // any function defined in an class is called method
    // so no need to give any 'function' keyword

    log(id, message){
        console.log(message);
    
    // we also want this method to be able to raise an event and
    // send any user defined data to any url
    // to make sure the Logger class is able to behave like
    // and EventEmitter class, we extend the EvenEmitter to Logger
        this.emit('logme', { location:url, msgid: id, data: message});
    // 'this' in case will point to current object
    }
}

module.exports=Logger;
//export the logger class