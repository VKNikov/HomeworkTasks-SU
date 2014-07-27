/**
 * Created by VKNikov on 24.7.2014 г..
 */

//Problem 9.	Most Frequent Number
//Write a JavaScript function findMostFreqNum(value) that finds the most frequent number in an array.
// If multiple numbers appear the same maximal number of times, print the leftmost of them.
// Write JS program numberFinder.js that invokes your function with the sample input data below and prints the output at the console.

console.log('This script finds the leftmost number that appear most often in a given array.');
console.log();

function findMostFreqNum(arr) {
    "use strict";

    var n = arr.length;
    var numbers = {};

    for (var i = 0; i < n; i += 1) {
        if (arr[i] in numbers) {
            numbers[arr[i]] += 1;
        } else {
            numbers[arr[i]] = 1;
        }
    }

    var keyValue = '';
    var instances = 0;

    //Note that the order in objects is not guaranteed. This is supposed to work OK as long as you do not meddle
    // with the keys in the object (i.e. delete some key).
    for (var item in numbers) {
        if (numbers[item] > instances) {
            keyValue = item;
            instances = numbers[item];
        }
    }

    console.log('%s (%s times)', keyValue, instances);
}

findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);
findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]);