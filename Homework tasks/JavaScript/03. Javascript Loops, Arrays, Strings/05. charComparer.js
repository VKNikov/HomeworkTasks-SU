/**
 * Created by VKNikov on 22.7.2014 г..
 */

//Problem 5.	Compare Chars
//Write a JavaScript function compareChars(value) that compares two arrays of chars lexicographically (letter by letter).
// Write JS program charComparer.js that invokes your function with the sample input data below and prints the output at the console.

function compareChars(firstArray, secondArray) {
    "use strict";

    var equal = true;

    for (var char in firstArray) {
        if (firstArray[char] !== secondArray[char]) {
            equal = false;
            break;
        }
    }

    console.log(equal?'Equal':'Not Equal')
}

compareChars(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'], ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']);
compareChars(['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']);
compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']);