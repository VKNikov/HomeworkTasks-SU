/**
 * Created by VKNikov on 22.7.2014 г..
 */

//Problem 2.	Find Min and Max Number
//Write a JavaScript function findMinAndMax(value) that accepts as parameter an array of numbers.
// The function finds the minimum and the maximum number. Write a JS program minMaxNumbers.js
// that invokes your function with the sample input data below and prints the output at the console

console.log('This script finds the minimum and the maximum number within an array of numbers');
console.log();

function findMinAndMax (value) {
    "use strict";

    var min = value[0];
    var max = value[0];

    for (var index in value) {
        if (value[index] < min) {
            min = value[index];
        }

        if (value[index] > max) {
            max = value[index];
        }
    }

    console.log('Min -> %d', min);
    console.log('Max -> %d', max);
}

findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]);
findMinAndMax([2, 2, 2, 2, 2]);
findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]);