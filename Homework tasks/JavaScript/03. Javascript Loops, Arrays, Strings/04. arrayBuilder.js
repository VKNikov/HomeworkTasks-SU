/**
 * Created by VKNikov on 22.7.2014 г..
 */

//Problem 4.	Create Array
//Write a JavaScript function createArray(value) that allocates array of 20 integers and initializes each element
// by its index multiplied by 5. Write JS program arrayBuilder.js that invokes your function with
// the sample input data below and prints the output at the console.

function createArray() {
    "use strict";

    var sampleArray = new Array(20);
    var n = sampleArray.length;

    for (var i = 0; i < n; i += 1) {
        sampleArray[i] = i * 5;
    }

    console.log(sampleArray);
}

createArray();