import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

//Problem 9. Combine Lists of Letters
//Write a program that reads two lists of letters l1 and l2 and combines them: appends all letters c from l2 to the end of l1, but only when c does not appear in l1. 
//Print the obtained combined list. All lists are given as sequence of letters separated by a single space, each at a separate line. 
//Use ArrayList<Character> of chars to keep the input and output lists.

public class _09_CombineListsOfLetters {

	public static void main(String[] args) {
		System.out.println("This program reads two lists of letters and combines the different letters in the lists.");
		System.out.println("Please enter the lists:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		List<Character> firstList = new ArrayList<>();
		List<Character> secondList = new ArrayList<>();
		List<Character> finalList = new ArrayList<>();
		
		for (char c : input.nextLine().toCharArray()) {
			firstList.add(c);
		}
		
		for (char c : input.nextLine().toCharArray()) {
			secondList.add(c);
		}
		
		finalList.addAll(firstList);
		
		for (int i = 0; i < secondList.size(); i++) {
			if (!finalList.contains(secondList.get(i))) {
				finalList.add(' ');
				finalList.add(secondList.get(i));
			}
		}

		for (Character c : finalList) {
			System.out.print(c);
		}
	}
}
