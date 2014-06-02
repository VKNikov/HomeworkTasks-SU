import java.util.Scanner;

/*Problem 2. Generate 3-Letter Words
Write a program to generate and print all 3-letter words consisting of given set of characters. For example if we have the characters 'a' and 'b', all possible words will be "aaa", "aab", "aba", "abb", "baa", "bab", "bba" and "bbb". The input characters are given as string at the first line of the input. Input characters are unique (there are no repeating characters).*/

public class _02_Generate_3_Letter_Word {

	public static void main(String[] args) {
		System.out.println("This program will generate and print all 3 letter words consisting of given set of characters");
		System.out.println("Please enter the characters");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String word = input.nextLine();
		System.out.println("All the 3 letter words consisting of your input are:");
		
		for (int i = 0; i < word.length(); i++) {
			
			for (int j = 0; j < word.length(); j++) {
				
				for (int k = 0; k < word.length(); k++) {
					
					System.out.print(Character.toString(word.charAt(i)) + word.charAt(j) + word.charAt(k) + " ");
				}
			}
		}
	}
}
