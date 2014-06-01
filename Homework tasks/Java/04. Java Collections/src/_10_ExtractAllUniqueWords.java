import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

//Problem 10. Extract All Unique Words
//At the first line at the console you are given a piece of text. Extract all words from it and print them in alphabetical order. Consider each non-letter character as word separator. 
//Take the repeating words only once. Ignore the character casing. Print the result words in a single line, separated by spaces.

public class _10_ExtractAllUniqueWords {

	public static void main(String[] args) {
		System.out.println("This program extracts all words from a given text and prints them in alphabetical order");
		System.out.println("Please enter a text:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		Set<String> sortedSet = new TreeSet<>();
		
		for (String word : input.nextLine().toLowerCase().split("[ ,.;:'?!]")) {
			sortedSet.add(word);
		}
		
		for (String word : sortedSet) {
			System.out.print(word + " ");
		}
	}

}
