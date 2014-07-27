/**
 * Created by VKNikov on 22.7.2014 г..
 */

//Problem 1.	Number Checker
//Write a JavaScript function printNumbers(n) that accepts as parameter integer n.
// The function finds all integer numbers from 1 to n that are not divisible by 4 or by 5.
// Write a JS program numberChecker.js that invokes your function with the sample input data below and prints the output at the console.

console.log('This script finds all integer numbers from 1 to n that are not divisible by 4 or 5. It uses a couple of predefined samples as a test.');
console.log();

function printNumbers(n) {
    "use strict";

    var numbers = [];

    for (var i = 1; i <= n; i += 1) {
        if (i % 4 != 0 && i % 5 != 0) {
            numbers.push(i);
        }
    }

    if (numbers != '') {
        console.log(numbers);
    } else {
        console.log('no');
    }

}

printNumbers(20);
printNumbers(-5);
printNumbers(13);