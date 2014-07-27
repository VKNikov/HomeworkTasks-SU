/**
 * Created by VKNikov on 21.7.2014 г..
 */

//Problem 13.	*Digital Soothsayer
//Write a JavaScript function soothsayer(value) that accepts the following parameters (source arrays):
// array of numbers, array of programming languages, array of cities, array of cars. Each array must consist of five elements.
// The function must return an array result[] that consists of one random item from each source array.
// Write a JS program that prints on the console the following output: “You will work result[0] years on result[1].
// You will live in result[2] and drive result[3].”.  Run the program through Node.js.

var result = [];

function soothsayer(value) {
    "use strict";

    var numbers = [];
    var progLang = [];
    var cities = [];
    var cars = [];

    numbers = value[0];
    progLang = value[1];
    cities = value[2];
    cars = value[3];


    return result = [numbers[Math.floor(Math.random() * numbers.length)],
        progLang[Math.floor(Math.random() * progLang.length)],
        cities[Math.floor(Math.random() * cities.length)],
        cars[Math.floor(Math.random() * cars.length)]]
}

soothsayer([[3, 5, 2, 7, 9], ['Java', 'Python', 'C#', 'JavaScript', 'Ruby'], ['Silicon Valley', 'London', 'Las Vegas', 'Paris', 'Sofia'], ['BMW', 'Audi', 'Lada', 'Skoda', 'Opel']]);

console.log('You will work %d years on %s. You will live in %s and drive %s.', result[0], result[1], result[2], result[3]);