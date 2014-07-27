/**
 * Created by VKNikov on 25.7.2014 г..
 */

//Problem 12.	Substring Count
//Write a JavaScript function countSubstringOccur(value) that accepts as parameter an array of 2 elements arr [keyword, text].
// The function finds how many times a substring is contained in a given text (perform case insensitive search).
// Write JS program substringSearch.js that invokes your function with the sample input data below and prints the output at the console.

console.log('This script finds how many times a substring is contained in a given text.');
console.log();

function countSubstringOccur(arr) {
    "use strict";

    var pattern = new RegExp(arr[0], 'gi');
    var text= arr[1];

    var result = text.match(pattern);

    console.log(result.length);
}

countSubstringOccur(['in', 'We are living in a yellow submarine. We don\'t have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.']);
countSubstringOccur(['your', 'No one heard a single word you said. They should have seen it in your eyes. What was going around your head.']);
countSubstringOccur(['but', 'But you were living in another world tryin\' to get your message through.']);