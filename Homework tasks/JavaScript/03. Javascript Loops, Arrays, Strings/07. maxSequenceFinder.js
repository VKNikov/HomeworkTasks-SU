/**
 * Created by VKNikov on 23.7.2014 г..
 */

//Problem 7.	Maximal Increasing Sequence
//Write a JavaScript function findMaxSequence(value) that finds the maximal increasing sequence in an array of
// numbers and returns the result as an array. If there is no increasing sequence the function returns 'no'.
//Write JS program maxSequenceFinder.js that invokes your function with the sample input data below and prints the output at the console.

function findMaxSequence(arr) {
    "use strict";

    var counter = 1;
    var sequence = [];
    var innerCounter;
    var n = arr.length;

    for (var i = 1; i < n; i++) {
        if (arr[i] > arr[i - 1]) {
            counter++;
        } else {
            counter = 1;
        }

        if (counter > 1 && counter > sequence.length) {
            innerCounter = 0;
            sequence = [];
            for (var j = 0; j < counter; j++) {
                sequence.push(arr[i - innerCounter]);
                innerCounter++;
            }
        }
    }

    if (sequence != '') {
        console.log(sequence.reverse());
    } else {
        console.log('no');
    }
}

findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
findMaxSequence([3, 2, 1]);