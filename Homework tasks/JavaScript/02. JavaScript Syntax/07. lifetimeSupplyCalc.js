/**
 * Created by VKNikov on 20.7.2014 г..
 */

//Problem 7.	The Lifetime Supply Calculator
//Write a JavaScript function calcSupply(value) that accepts the following parameters:
// your age, your maximum age, estimate amount of your favorite food per day (as a number).
// The function calculates how many of the food you will eat for the rest of your life.
// Write JS program lifetimeSupplyCalc.js that calculates the amount of a few foods that you will eat.
// The result should be printed on the console. Run the program through Node.js.
// Note: we assume that there are no leap years.

console.log('This script calculates how many food you will eat for the rest of your life.');
console.log();

function calcSupply(age, maxAge, foodPerDay) {
    "use strict";
     var totalFood = (maxAge - age)* 365 * foodPerDay;
    return totalFood;
}

console.log(calcSupply(38, 118, 0.5) + ' of chocolate would be enough until I am 118 years old.')
console.log(calcSupply(20, 87, 2) + ' of fruits would be enough until I am 87 years old.');
console.log(calcSupply(16, 102, 1.1) + ' of nuts would be enough until I am 102 years old.');

