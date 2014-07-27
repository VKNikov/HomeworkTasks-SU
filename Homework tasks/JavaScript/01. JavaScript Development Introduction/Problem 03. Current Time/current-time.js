/**
 * Created by VKNikov on 16.7.2014 г..
 */

//Write a JavaScript program current-time.js that prints on the console the current time in format hours:minutes.
// The hours should be printed without leading zeroes. The minutes should be printed as two-digit number with a leading zero when needed.
// Execute your program through Node.js.

var currentTime = new Date();
var hours = currentTime.getHours();
var minutes = currentTime.getMinutes();

if (minutes < 10) {
    console.log(hours + ":0" + minutes);
} else {
    console.log(hours + ":" + minutes);
}

