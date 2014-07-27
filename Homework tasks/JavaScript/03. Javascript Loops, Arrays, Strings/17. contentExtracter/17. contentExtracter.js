/**
 * Created by VKNikov on 26.7.2014 г..
 */

//Problem 17.	* Extract Element Content
//Write a JavaScript function extractContent(value) that extracts the text content from given HTML fragment
// (given as string). The function should return anything that is in a tag, without the tags.
// Write JS program contentExtracter.js that invokes your function with the sample input data below and
// prints the output at the console.
//Hint: Create an element and use its innerHTML and innerText properties.

//Open the index.html page and then the browser's console to see the result.
function extractContent(str) {
    "use strict";

    var element = document.createElement('div');
    element.innerHTML = str;
    document.body.appendChild(element);
    var result = element.textContent;
    console.log(result);

}

extractContent("<p>Hello</p><a href='http://w3c.org'>W3C</a>");