/**
 * Created by VKNikov on 20.7.2014 г..
 */

//Problem 8.	Cylinder Volume
//Write a JavaScript function calcCylinderVol(value) that accepts the following parameters:
// radius and the height of a straight circular cylinder. The function calculates the volume of the cylinder.
// Write JS program cylinderVol.js that calculates the volume of a few cylinders.
// The result should be printed on the console. Run the program through Node.js.

console.log('This script calculates the volume of some predefined cylinders');
console.log();

function calcCylinder(r, h) {
    "use strict";

    var volume = Math.PI * Math.pow(r, 2) * h;
    console.log(volume.toFixed(3));
}

calcCylinder(2, 4);
calcCylinder(5, 8);
calcCylinder(12, 3);