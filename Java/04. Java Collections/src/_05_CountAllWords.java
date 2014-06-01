import java.util.Scanner;

//Problem 5. Count All Words
//Write a program to count the number of words in given sentence. Use any non-letter character as word separator.

public class _05_CountAllWords {

	@SuppressWarnings({ "unused", "resource" })
	public static void main(String[] args) {
		System.out.println("This program counts the number of the words in a given sentence.");
		System.out.println("Please enter a sentence:");
		Scanner input = new Scanner(System.in);
		String[] separatedWords = input.nextLine().split("[,.;:'!?\\- ]+");
		int counter = 0;
		
		for (String word : separatedWords) {
			counter++;
		}
		
		System.out.println(counter);
	}

}
