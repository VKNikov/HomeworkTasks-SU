/**
 * Created by VKNikov on 21.7.2014 г..
 */

//Problem 14.	* Calculate Expression
//Write a HTML page (with text field, button, and paragraph). Write JS program calcExpression.js that calculates
// any expression put in the text field and prints it in the paragraph.
// Link the JS file to the HTML file. (100% accuracy is not required).


function calculateExpression() {

    var input = document.getElementById('textbox').value;
    var modifiedInput  = input.replace(/[a-zA-Z;:!@?#$^&<>\/]/gi, '');

    try {
        if (modifiedInput != '') {
            document.getElementById('output').innerHTML = eval(modifiedInput);
        } else {
            throw error;
        }
    }
    catch (error) {
        document.getElementById('output').innerHTML = 'Invalid input. Please try again.';
    }

}

