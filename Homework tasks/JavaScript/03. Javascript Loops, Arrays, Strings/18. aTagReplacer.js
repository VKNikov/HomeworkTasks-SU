/**
 * Created by VKNikov on 26.7.2014 г..
 */

//Problem 18.	*Replace <a> Tag
//Write a JavaScript function replaceATag(value) that replaces in a HTML document given as string all the tags
// <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Write JS program aTagReplacer.js that invokes your
// function with the sample input data below and prints the output at the console.

function replaceATag(str) {
    "use strict";

    var result = str.replace(/<a/g, '<URL').replace(/<\/a/g, '</URL');
    console.log(result);
}

replaceATag("<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>");