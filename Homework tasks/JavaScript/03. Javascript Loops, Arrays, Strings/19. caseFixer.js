/**
 * Created by VKNikov on 26.7.2014 г..
 */

//Problem 19.	**Text Modifier
//Write a JavaScript function fixCasing(value) that accepts a text as a parameter. The function must change the text in all regions as follows:
//    o	<upcase>text</upcase> to uppercase
//o	<lowcase>text</lowcase> to lowercase
//o	<mixcase>text</mixcase> to mixed casing (randomly)
//Write JS program caseFixer.js that invokes your function with the sample input data below and prints the output at the console.

function fixCasing(str) {
    "use strict";
    var input = str.split(/[ <>/]/gi);
    input = input.filter(function(a) {return a;})
    var n = input.length;

    function replaceAt(index, character) {
        return currentWord.substr(0, index) + character + currentWord.substr(index+character.length);
    }

    for (var i = 0; i < n; i++) {
        if (input[i] == 'upcase' || input[i] == 'lowcase' || input[i] == 'mixcase') {
            var currentCase = input[i];
            for (var j = i+1; j < n; j++) {
                if (input[j] == currentCase) {
                    i = j;
                    break;
                }
                switch (input[i]) {
                    case 'upcase': input[j] = input[j].toUpperCase();
                        break;
                    case 'lowcase': input[j] = input[j].toLowerCase();
                        break;
                    case 'mixcase':
                        var currentWord = input[j];
                        var length = currentWord.length;
                        for (var k = 0; k < length; k++) {
                            var rndNumber = Math.random();
                            if (rndNumber > 0.5) {
                                var character = currentWord[k].toUpperCase();
                                currentWord = replaceAt(k, character);
                            }
                        }
                        input[j] = currentWord;
                        break;
                }
            }
        }
    }

    for (var i = 0; i < n; i++) {
        if (input[i] == 'upcase' || input[i] == 'lowcase' || input[i] == 'mixcase') {
            delete input[i];
        }

    }

    console.log(input.join(" "));
}

fixCasing("We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.");