import java.util.Scanner;


//Problem 7.	Count Substring Occurrences
//Write a program to find how many times given string appears in given text as substring. The text is given at the first input line. 
//The search string is given at the second input line. The output is an integer number. Please ignore the character casing.

public class _07_CountSubstringOccurences {

	public static void main(String[] args) {
		System.out
				.println("This program finds how many times a given string apperas in a given text as substring.");
		System.out.println("Please enter the text:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String text = input.nextLine().toLowerCase();
		String seekedSequence = input.nextLine().toLowerCase();
		int counter = 0;

		for (int i = 0; i <= text.length() - seekedSequence.length(); i++) {
			if (text.substring(0 + i, seekedSequence.length() + i).contains(
					seekedSequence)) {
				counter++;
			}
		}

		System.out.println(counter);
	}

}
