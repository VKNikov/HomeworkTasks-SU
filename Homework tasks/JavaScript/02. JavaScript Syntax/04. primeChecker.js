/**
 * Created by VKNikov on 19.7.2014 г..
 */

//Write a JavaScript function isPrime(value) that checks if an integer number is prime.
// Write JS program primeChecker.js that checks if a few numbers are prime.
// The result should be printed on the console (true or false) on the console. Run the program through Node.js.

console.log('This script checks whether a predefined integer numbers (7, 254 and 587) are prime numbers or not.');

function isPrime(value) {
    "use strict";

    var prime = true;

    for (var i = 2; i <= Math.sqrt(value); i += 1) {
        if (value % i == 0) {
            prime = false;
        }
    }

    console.log(prime);
}

isPrime(7);
isPrime(254);
isPrime(587);