console.log("************************************************************");
console.log("This is coming from 12CodingChallenge4.js file");
let bill = 275;
let tip = bill >= 50 && bill <= 300 ? bill * 0.15 : bill * 0.2;
console.log(`Bill: ${bill}, tip: ${tip}, Total: ${bill + tip}`);

bill = 40;
tip = bill >= 50 && bill <= 300 ? bill * 0.15 : bill * 0.2;
console.log(`Bill: ${bill}, tip: ${tip}, Total: ${bill + tip}`);

bill = 430;
tip = bill >= 50 && bill <= 300 ? bill * 0.15 : bill * 0.2;
console.log(`Bill: ${bill}, tip: ${tip}, Total: ${bill + tip}`);
