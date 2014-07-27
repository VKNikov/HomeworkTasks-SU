/**
 * Created by VKNikov on 25.7.2014 г..
 */

//Problem 11.	Check the Brackets
//Write a JavaScript function checkBrackets(value) to check if in a given expression the brackets are put correctly.
// Write JS program bracketsChecker.js that invokes your function with the sample input data below and prints the output at the console.

function checkBrackets(str) {
    "use strict";

    var leftBracket = '';
    var rightBracket = '';
    var n = str.length;
    var firstIsLeft = true;

    for (var i = 0; i < n; i += 1) {
        if (str[i] == '(') {
           leftBracket += "(";
        } else if (str[i] == ')'){
            if (leftBracket == '') {
                firstIsLeft = false;
            }
            rightBracket += ')';
        }
    }

    if (firstIsLeft) {
        console.log(leftBracket.length == rightBracket.length? 'correct' : 'incorrect');
    } else {
        console.log('incorrect');
    }
}

checkBrackets('( ( a + b ) / 5 – d )');
checkBrackets(') ( a + b ) )');
checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )');