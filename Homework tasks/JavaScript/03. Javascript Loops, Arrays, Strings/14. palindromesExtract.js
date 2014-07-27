/**
 * Created by VKNikov on 25.7.2014 г..
 */

//Problem 14.	Palindromes
//Write a JavaScript function findPalindromes(value) that extracts from a given text all palindromes,
// e.g. "ABBA", "lamal", "exe". Write JS program palindromesExtract.js that invokes your function with the sample input
// data below and prints the output at the console.

console.log('This script finds all palindromes in a text.');
console.log();

function findPalindromes(str) {
    "use strict";
    str = str.toLowerCase().replace(/[\.,'";:]/g, '')
    var n = str.length;
    var reversedStr = '';

    for (var i = n - 1; i >= 0; i--) {
        reversedStr += str[i];
    }

    var strNormalArray = str.split(/\s/);
    var strReversedArray = reversedStr.split(/\s/);
    n = strNormalArray.length;
    var result = [];

    for (var i = 0; i < n; i += 1) {

        if (strReversedArray[i] == strNormalArray[(n - 1) - i]) {
            result.push(strReversedArray[i]);
        }
    }

    console.log(result.join(', '));
}

findPalindromes('There is a man, his name was Bob.');