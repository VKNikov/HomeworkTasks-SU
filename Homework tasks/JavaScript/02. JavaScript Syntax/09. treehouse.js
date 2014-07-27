/**
 * Created by VKNikov on 20.7.2014 г..
 */

//Problem 9.	Tree or House
//Write a JavaScript function treeHouseCompare(value) that accepts the following parameters: integers a and b.
// The function compares the area of the house and the area of the tree (Figure 1) and returns the name of the figure
// with bigger area (house or tree) and the value of the area. Write JS program treehouse.js that
// compares a few houses and trees. The result should be printed on the console. Run the program through Node.js.

function treeHouseCompare(house, tree) {
    var areaHouse = Math.pow(house, 2) + (house * (house - (house/3)))/2;
    var areaTree = tree * (tree/3) + (Math.PI * Math.pow(tree - (tree/3), 2));

    if(areaHouse > areaTree) {
        console.log('house/' + areaHouse.toFixed(2));
    } else {
        console.log('tree/' + areaTree.toFixed(2));
    }
}

treeHouseCompare(3, 2);
treeHouseCompare(3, 3);
treeHouseCompare(4, 5);
