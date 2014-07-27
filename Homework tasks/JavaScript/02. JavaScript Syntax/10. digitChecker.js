/**
 * Created by VKNikov on 20.7.2014 г..
 */

//Problem 10.	Digit Checker
//Write a JavaScript function checkDigit(value) that finds if the third digit (right-to-left) of an integer number n (n>1000) is 3.
// Write JS program digitChecker.js that checks a few numbers. The result (true or false) should be printed on the console.
// Run the program through Node.js.

console.log('This script checks if the third digit of an integer number (the numbers being 1235, 25368, 123456) is 3.')
console.log();

function checkDigit (value) {
    "use strict";

    var value = value.toString();
    console.log(value[value.length - 3] == 3? true: false);
}

checkDigit(1235);
checkDigit(25368);
checkDigit(123456);