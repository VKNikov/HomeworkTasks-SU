/**
 * Created by VKNikov on 17.7.2014 г..
 */

//Write a JavaScript function calcCircleArea(r) that takes as a parameter the radius of a rectangle and calculates and returns its area.
// Put the function in a file named circle-area.js. Write a HTML page circle-area.html that includes the script circle-area.js
// and calculates and prints in the page body the area of circles of size r=7, r=1.5 and r=20.

var first = 7;
var second = 1.5;
var third = 20;
var area;

function calcCircleArea (r) {
 return area = Math.PI * (r * r);
}

document.writeln("r=" + first + "; area=" +calcCircleArea(first));
document.write("<br />");
document.writeln("r=" + second + "; area=" + calcCircleArea(second));
document.write("<br />");
document.writeln("r=" + third + "; area=" + calcCircleArea(third));

