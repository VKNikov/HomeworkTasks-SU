/**
 * Created by VKNikov on 24.7.2014 г..
 */

//Problem 8.	Sort Array
//Sorting an array means to arrange its elements in increasing order. Write a JavaScript function sortArray(value)
// to sort an array. Use the "selection sort" algorithm: find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position, etc. Write JS program arraySorter.js that invokes
// your function with the sample input data below and prints the output at the console.

console.log('This script sorts in increasing order an array of numbers.');
console.log();

function sortArray(arr) {
    "use strict";
//    console.log(arr.sort(function(a, b) { return a - b;}));
    var n = arr.length;

    function swap(a, b) {
        var temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    for (var i = 0; i <n; i++) {

        for (var j = i+1; j < n; j++) {
            if (arr[i] > arr[j]) {
                swap(i, j);
            }
        }
    }

    console.log(arr);
}

sortArray([5, 4, 3, 2, 1]);
sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]);