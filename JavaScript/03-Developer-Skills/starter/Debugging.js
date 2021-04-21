const measureKelvin = () => {
  const measurement = {
    type: "temp",
    unit: "celcius",
    value: prompt("Degrees celcius"), //this is a bug
    // value: Number(prompt("Degree Celcius:")),
  };

  //debugger; //you can call this debugger; statement to call debugger

  const kelvin = measurement.value + 273;
  console.log(measurement.value);
  console.warn(measurement.value);
  console.error(measurement.value);
  console.table(measurement); //usefull for bigger objects
  return kelvin;
};

console.log(measureKelvin());
