/**
 * Created by VKNikov on 20.7.2014 г..
 */

//Problem 11.	Digit as Word
//Write a JavaScript function convertDigitToWord(value) that prints the name of an integer number n (0<n<10) in English using switch statement.
// Write JS program digitAsWord.js that prints a few digits on the console. Run the program through Node.js.

console.log('This script converts predefined integer numbers (8, 3 and 5) (and between 0 and 10 excluding) to word.');
console.log();

function convertDigitToWord(value) {
    "use strict";

    switch (value) {
        case 1: console.log('one');
            break;
        case 2: console.log('two');
            break;
        case 3: console.log('three');
            break;
        case 4: console.log('four');
            break;
        case 5: console.log('five');
            break;
        case 6: console.log('six');
            break;
        case 7: console.log('seven');
            break;
        case 8: console.log('eight');
            break;
        case 9: console.log('nine');
            break;
        default: console.log('Invalid input!');
    }
}

convertDigitToWord(8);
convertDigitToWord(3);
convertDigitToWord(5);