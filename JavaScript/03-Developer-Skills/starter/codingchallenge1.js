/**
 * TODO
 * 1. scroll thourgh the input
 * 2.display the ouput for each iteration
 */

const Data1 = [17, 21, 23];
const Data2 = [12, 5, -5, 0, 4];

const printForecast = function (arr) {
  //   console.log(this); //for some reason this is pointing to the global object
  let str = "";
  for (let i = 0; i < arr.length; i++) {
    // console.log(`...${arr[i]}\u00B0C in ${i + 1} day(s)...`);
    str += `...${arr[i]}\u00B0C in ${i + 1} day(s)...`;
  }
  return str;
};
console.log(printForecast(Data1));
console.log(printForecast(Data2));
