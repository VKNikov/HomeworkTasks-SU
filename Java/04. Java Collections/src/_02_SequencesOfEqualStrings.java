import java.util.Scanner;

//Problem 3. Sequences of Equal Strings
//Write a program that enters an array of strings and finds in it all sequences of equal elements. The input strings are given as a single line, separated by a space.

public class _02_SequencesOfEqualStrings {

	public static void main(String[] args) {
		System.out
				.println("This program receives an array of strings and then finds all sequences of equal elements. Finally, it prints the strings to the console.");
		System.out.println("Please enter the array of strings:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String[] inputAsArray = input.nextLine().split(" ");

		for (int i = 0; i < inputAsArray.length; i++) {

			if (i == 0) {
				if ((i < inputAsArray.length - 1)
						&& inputAsArray[i].equals(inputAsArray[i + 1])) {
					System.out.print(inputAsArray[i] + " ");
				} else {
					System.out.println(inputAsArray[i]);
				}

			} else if ((i < inputAsArray.length - 1)) {
				if (inputAsArray[i].equals(inputAsArray[i + 1])) {
					System.out.print(inputAsArray[i] + " ");
				} else {
					System.out.println(inputAsArray[i]);
				}

			} else {
				System.out.println(inputAsArray[i]);
			}

		}

	}

}
