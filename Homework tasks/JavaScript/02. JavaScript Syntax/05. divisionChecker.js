/**
 * Created by VKNikov on 19.7.2014 г..
 */

//Write a JavaScript function divisionBy3(value) that finds the sum of digits of integer number n (n > 9) and checks if the sum is divided by 3 without remainder.
// Write JS program divisionChecker.js to check a few numbers. The result should be printed on the console
// (“the number is divided by 3 without remainder” or “the number is not divided by 3 without remainder”). Run the program through Node.js.

console.log('This script checks whether the sum of the digits of an integer number (where number > 9) is divisible by 3 without a remainder.')

function divisionBy3 (value) {
    "use strict";

    var value = value.toString();
    var numberLength = value.length;
    var sum = 0;

    for(var i= 0; i < numberLength; i += 1) {
        sum += parseInt(value[i]);
    }

    if ((sum % 3) == 0) {
        console.log('The number is divided by 3 without remainder.')
    } else {
        console.log('The number is not divided by 3 without remainder.')
    }
}

divisionBy3(12);
divisionBy3(188);
divisionBy3(591);