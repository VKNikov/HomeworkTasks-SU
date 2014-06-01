import java.util.Scanner;

//Problem 3. Largest Sequence of Equal Strings
//Write a program that enters an array of strings and finds in it the largest sequence of equal elements. If several sequences have the same longest length, print the leftmost of them. The input strings are given as a single line, separated by a space.

public class _03_LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		System.out
				.println("This program finds the largest sequence of equal elements and prints it.");
		System.out.println("Please enter a sequence:");
		
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String[] inputAsArray = input.nextLine().split(" ");
		int currentCounter = 1;
		int totalCounter = 1;
		String sequence = null;

		if (inputAsArray.length > 1) {
			sequence = inputAsArray[0];

			for (int i = 0; i < inputAsArray.length; i++) {

				if ((i < inputAsArray.length - 1)
						&& inputAsArray[i].equals(inputAsArray[i + 1])) {
					if (currentCounter >= totalCounter) {
						totalCounter = currentCounter;
						currentCounter++;
						sequence = inputAsArray[i];
					} else {
						currentCounter++;
					}

				} else if (i == inputAsArray.length - 1) {
					if (sequence.equals(inputAsArray[i])
							&& inputAsArray[i].equals(inputAsArray[i - 1])) {
						totalCounter++;
					}

				} else if (i > 0 && inputAsArray[i].equals(inputAsArray[i - 1])) {
					totalCounter = currentCounter;
					currentCounter = 1;
				} else {
					currentCounter = 1;
				}
			}

			for (int j = 0; j < totalCounter; j++) {
				System.out.print(sequence + " ");
			}
		} else {
			System.out.println(inputAsArray[0]);
		}

	}

}
