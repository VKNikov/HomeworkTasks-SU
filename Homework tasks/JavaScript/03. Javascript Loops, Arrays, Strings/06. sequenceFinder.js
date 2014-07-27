/**
 * Created by VKNikov on 22.7.2014 г..
 */

//Problem 6.	Maximal Sequence
//Write a JavaScript function findMaxSequence(value) that finds the maximal sequence of equal elements
// in an array and returns the result as an array. If there is more than one sequence with the same maximal length,
// print the rightmost one. Write JS program sequenceFinder.js that invokes your function
// with the sample input data below and prints the output at the console.

function findMaxSequence(arr) {
    "use strict";

    var counter = 1;
    var tempCounter = 1;
    var position = 0;
    var n = arr.length;

    for (var i = 1; i < n; i += 1) {
        if (arr[i] === arr[i-1]) {
            tempCounter ++;
        } else {
            tempCounter = 1;
        }
        if (counter <= tempCounter) {
            counter = tempCounter;
            position = i;
        }
    }

    function printSequence() {
        var number = [];

        for (var i = 0; i < counter; i++) {
            number.push(arr[position])
        }
        return number;
    }

    console.log(printSequence());
}

findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
findMaxSequence(['happy']);
findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);
