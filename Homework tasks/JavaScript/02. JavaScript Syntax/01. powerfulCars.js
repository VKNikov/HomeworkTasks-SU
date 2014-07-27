/**
 * Created by VKNikov on 19.7.2014 г..
 */

//Write a JavaScript function convertKWtoHP(value) to convert car’s kW into hp (horse power).
// Write a JS program 01. powerfulCars.js that converts a few sample values to hp (see the examples below).
// The result should be printed on the console, rounded up to the second sign after the decimal point. Run the program through Node.js.

"use strict";

console.log("This program converts a couple of predefined car's KW values into HP values.")
console.log();

var hp;

function convertKWtoHP(kW) {
    var divisor =  0.745699872;
    return hp = (kW/divisor).toFixed(2);
}

console.log("75kW are equal to " + convertKWtoHP(75) + "hp");
console.log("150kW are equal to " + convertKWtoHP(150) + "hp");
console.log("1000kW are equal to " + convertKWtoHP(1000) + "hp");