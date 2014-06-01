import java.util.Scanner;



//Problem 8. Count Substring Occurrences
//Write a program to find how many times given string appears in given text as substring. The text is given at the first input line. 
//The search string is given at the second input line. The output is an integer number. Please ignore the character casing. 

public class _06_CountSpecifiedWords {

	public static void main(String[] args) {
		System.out.println("This program finds how many times a given string appears in a given text as substring.");
		System.out.println("Please enter the text:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String[] separatedWords = input.nextLine().split("[,.;:'?!() ]");
		String wordToSearch = input.nextLine();
		int counter = 0;
		
		for (String word : separatedWords) {
			if (word.equalsIgnoreCase(wordToSearch)) {
				counter++;
			}
		}
		System.out.println(counter);

	}

}
