/**
 * Created by VKNikov on 19.7.2014 г..
 */

//Write a JavaScript function roundNumber(value) that rounds floating-point number using Math.round(), Math.floor().
// Write a JS program 02. roundingNumbers.js that rounds a few sample values. Run the program through Node.js

"use strict";

console.log('This program rounds a couple of predefined floating-point numbers using both Math.round() and Math.floor().');
console.log();

function roundNumber(number) {
    console.log(Math.floor(number));
    console.log(Math.round(number));
}

roundNumber(22.7);
roundNumber(12.3);
roundNumber(58.7);
