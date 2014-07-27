/**
 * Created by VKNikov on 19.7.2014 г..
 */

//Write a JavaScript function evenNumber(value) that checks if an integer number is even.
// Write JS program evenChecker.js to check if a few numbers are even.
// The result should be printed on the console (true or false). Run the program through Node.js.

console.log('This script checks if whether a predefined integer numbers (3, 127 and 588) are even or not.');

function evenNumber(value) {
    "use strict";
    if (value % 2 == 0) {
        console.log('true');
    } else {
        console.log('false');
    }
}

evenNumber(3);
evenNumber(127);
evenNumber(588);