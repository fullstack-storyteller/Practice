const log=require('./app2')

const request=log.handler;
request.emit('logging', {data: 'this is a test request'});