/**
 * Created by VKNikov on 25.7.2014 г..
 */

//Problem 13.	Replace the White-Spaces
//Write a JavaScript function replaceSpaces(value) that replaces the white-space characters in a text with &nbsp;.
// Write JS program spaceReplacer.js that invokes your function with the sample input data below and prints the output at the console.


console.log('This script replaces the whitespace chars in a text with "&nbsp;"');
console.log();

function replaceSpaces(str) {
    "use strict";

    var result = str.replace(/ /g, '&nbsp;');

    console.log(result);
}

replaceSpaces('But you were living in another world tryin\' to get your message through');