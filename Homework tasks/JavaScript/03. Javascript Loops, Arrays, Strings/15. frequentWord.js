/**
 * Created by VKNikov on 25.7.2014 г..
 */

//Problem 15.	Most Frequent Word
//Write a JavaScript function findMostFreqWord(value) that finds the most frequent word in a text and prints it,
// as well as how many times it appears in format "word -> count". Consider any non-letter character as a word separator.
// Ignore the character casing. If several words have the same maximal frequency, print all of them in alphabetical order.
// Write JS program frequentWord.js that invokes your function with the sample input data below and prints the output at the console.

console.log('This script find the most frequent word in a text and prints it.');
console.log();

function findMostFrequentWord(str) {
    "use strict";

    str = str.toLowerCase();
    var strAsArray = str.split(/[,.;:-_0-9 ]/g);
    strAsArray = strAsArray.filter(function(a) {return a;});
    var n = strAsArray.length;

    //Initially I used this code to remove the empty indexes from the array, but later on found out about the filter method.
//    for (var i = 0; i < n; i++) {
//        if (strAsArray[i] == '') {
//            strAsArray.splice(i, 1);
//        }
//    }
//    n = strAsArray.length;

    var counter = 0;
    var wordsCounted = {};
    var result = [];

    for (var i = 0; i < n; i++) {
        if (strAsArray[i] in wordsCounted) {
            wordsCounted[strAsArray[i]] += 1;
        } else {
            wordsCounted[strAsArray[i]] = 1;
        }
    }

    for (var item in wordsCounted ) {
        if (counter < wordsCounted[item]) {
            counter = wordsCounted[item];
        }
    }
    
    for (var item in wordsCounted) {
        if (wordsCounted[item] == counter) {
            result.push([item, wordsCounted[item]]);
        }
    }

    result.sort();
    n = result.length;

    for (var i = 0; i < n; i++) {
        console.log('%s -> %d times', result[i][0], result[i][1])
    }
}

findMostFrequentWord('in the middle of the night');
findMostFrequentWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
findMostFrequentWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');