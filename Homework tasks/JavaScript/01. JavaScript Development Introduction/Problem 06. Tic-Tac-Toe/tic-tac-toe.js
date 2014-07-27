/**
 * Created by VKNikov on 20.7.2014 г..
 */

var winningCombinations = [[1,2,3], [4,5,6], [7,8,9], [1,5,9], [3, 5, 7], [1, 4, 7], [2, 5, 8], [3, 6, 9]];
var turn = 0;
var cxt;

function boxClicked(box) {
    if (turn % 2 == 0) {
        cxt.beginPath();
        cxt.moveTo(10,10);
        cxt.lineTo(40,40);
        cxt.moveTo(40,10);
        cxt.lineTo(10,40);
        cxt.stroke();
        cxt.closePath();
    }
}