/**
 * Created by VKNikov on 26.7.2014 г..
 */

//Problem 16.	Cards Frequencies
//Write a JavaScript function findCardFrequency(value) that that accepts the following parameters: array of several
// cards (face + suit), separated by a space. The function calculates and prints at the console the frequency of
// each card face in format "card_face -> frequency". The frequency is calculated by the formula appearances / N and is
// expressed in percentages with exactly 2 digits after the decimal point. The card faces with their frequency
// should be printed in the order of the card face's first appearance in the input. The same card can appear multiple
// times in the input, but its face should be listed only once in the output. Write JS program cardFrequencies.js that
// invokes your function with the sample input data below and prints the output at the console.

console.log('This script takes an array of several cards and prints the frequency of each card face.');
console.log();

function findCardFrequency(arr) {
    "use strict";
    var splittedInput = arr.split(/ /g);
    var n = splittedInput.length;
    var container = {};

    for (var i = 0; i < n; i++) {
        var character = splittedInput[i].charAt(0);
        if (!(character in container)) {
            container[character] = 1;
        } else {
            container[character] += 1;
        }
    }

    for (var i = 0; i < n; i++) {
        var character = splittedInput[i].charAt(0);
        if ((character in container)) {
            console.log(character + ' -> ' + (container[character]/n * 100).toFixed(2) + '%');

            delete container[character];
        }
    }

    //console.log(container);
}

findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦');
findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠');
findCardFrequency('10♣ 10♥');