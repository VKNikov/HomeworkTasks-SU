/**
 * Created by VKNikov on 20.7.2014 г..
 */

//Write a JavaScript function bitChecker(value) that finds if the bit 3 an integer number (counting from 0) is 1.
// Write JS program checkingBits.js to check a few numbers. The result (true or false) should be printed on the console.
// Run the program through Node.js.

console.log('This script checks whether bit 3 of a predefined integer number is 1. If it is one, the script will return true.');
console.log();

function bitChecker(value) {
    "use strict";

    var mask = 1;
    var thirdBit = (value & (mask << 3));

    if((thirdBit >> 3) == 1) {
        console.log('true');
    } else {
        console.log('false');
    }

}

bitChecker(333);
bitChecker(425);
bitChecker(2567564754);
