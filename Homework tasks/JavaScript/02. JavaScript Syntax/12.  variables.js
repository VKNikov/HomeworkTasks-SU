/**
 * Created by VKNikov on 20.7.2014 г..
 */

//Problem 12.	Variables
//Write a JavaScript function variablesTypes(value) that accepts the following parameters:
// name, age, isMale (true or false), array of your favorite foods.
// The function must return the values of the variables and their types.

function variablesTypes(value) {
    "use strict";

    var obj = [];
    obj.name = value[0];
    obj.age = value[1];
    obj.isMale = value[2];
    obj.favoriteFood = value[3];

    console.log('My name: ' + obj.name + ' //type is ' + typeof obj.name);
    console.log('My age: ' + obj.age + ' //type is ' + typeof obj.age);
    console.log('I am male: ' + obj.isMale + ' //type is ' + typeof obj.isMale);
    console.log('My favorite foods are: ' + obj.favoriteFood + ' //type is ' + typeof obj.favoriteFood);
}

variablesTypes(['Pesho', 22, true, ['fries', 'banana', 'cake']]);