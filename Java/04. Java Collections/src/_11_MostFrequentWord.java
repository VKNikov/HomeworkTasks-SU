import java.util.Map;
import java.util.Map.Entry;
import java.util.Scanner;
import java.util.TreeMap;


//Problem 11. Most Frequent Word
//Write a program to find the most frequent word in a text and print it, as well as how many times it appears in format "word -> count". Consider any non-letter character as a word separator. 
//Ignore the character casing. If several words have the same maximal frequency, print all of them in alphabetical order.

public class _11_MostFrequentWord {

	public static void main(String[] args) {
		System.out
				.println("This program finds the most frequent word in a text and prints the word as well as "
						+ "how many times it appears in the text");
		System.out.println("Please enter a text:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		Map<String, Integer> sortedWords = new TreeMap<>();
		int totalCounter = 0;

		for (String word : input.nextLine().toLowerCase().split("[ ,.;:'?!]+")) {
			Integer counter = sortedWords.get(word);
			if (counter == null) {
				counter = 1;
			} else {
				counter += 1;
			}

			if (totalCounter < counter) {
				totalCounter = counter;
			}
			sortedWords.put(word, counter);

		}
//
		 for (Entry<String, Integer> word : sortedWords.entrySet()) {
		 //if (word.getValue() == totalCounter) {
		 System.out.printf("%s -> %d times\n", word.getKey(),
		 word.getValue());
		 }
		 //}
	}

}
