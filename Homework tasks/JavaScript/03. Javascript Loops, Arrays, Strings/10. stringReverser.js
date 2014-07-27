/**
 * Created by VKNikov on 25.7.2014 г..
 */

//Problem 10.	Reverse String
//Write a JavaScript function reverseString(value) that reverses string and returns it. Write JS program stringReverser.js
// that invokes your function with the sample input data below and prints the output at the console.

console.log('This script reverses a string and returns a reversed string.');
console.log();

function reverseString(str) {
    "use strict";

    var stringReversed = '';
    var n = str.length;

    for (var i = n-1; i >= 0; i -= 1) {
       stringReversed += str[i];
    }

    console.log(stringReversed);
}

reverseString('sample');
reverseString('softUni');
reverseString('java script');