const Logger =require('./ExtendedEvents1');

const logger = new Logger();

//register a listener
logger.on('logme', (msg)=>{
    console.log('logme listener called', msg);
} );

logger.log(100, 'This is a custom message from app.');
