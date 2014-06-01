import java.util.Scanner;

//Problem 4. Longest Increasing Sequence
//Write a program to find all increasing sequences inside an array of integers. The integers are given in a single line, separated by a space. 
//Print the sequences in the order of their appearance in the input array, each at a single line. Separate the sequence elements by a space. 
//Find also the longest increasing sequence and print it at the last line. If several sequences have the same longest length, print the leftmost of them. 

public class _04_LongestIncreasingSequence {

	public static void main(String[] args) {
		System.out
				.println("This program finds all increasing sequences of integers.");
		System.out.println("Please enter a sequence:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String[] inputAsStringArray = input.nextLine().split(" ");
		int[] numbers = new int[inputAsStringArray.length];
		int currentCounter = 1;
		int totalCounter = 0;
		int positionOfSequence = 0;

		populateArray(inputAsStringArray, numbers);

		printSequences(numbers, currentCounter, totalCounter, positionOfSequence);
		
		printLongestSequence(numbers, totalCounter, positionOfSequence);

	}

	private static void populateArray(String[] inputAsStringArray, int[] numbers) {
		for (int i = 0; i < inputAsStringArray.length; i++) {
			numbers[i] = Integer.parseInt(inputAsStringArray[i]);
		}
	}

	private static void printSequences(int[] numbers, int currentCounter,
			int totalCounter, int positionOfSequence) {
		System.out.print(numbers[0]);
		for (int i = 1; i < numbers.length; i++) {
			if (numbers[i] > numbers[i - 1]) {
				System.out.print(" " + numbers[i]);
				currentCounter++;
				if (totalCounter < currentCounter) {
					totalCounter = currentCounter;
					positionOfSequence = i - (currentCounter - 1);
				}
			} else {
				System.out.print("\n" + numbers[i]);
				currentCounter = 1;
			}
		}

	}
	
	private static void printLongestSequence(int[] numbers, int totalCounter,
			int positionOfSequence) {
		System.out.print("\nLongest: ");

		if (totalCounter > 0) {
			for (int i = 0; i < totalCounter; i++) {
				System.out.print(numbers[positionOfSequence + i] + " ");
			}
		} else {
			System.out.print(numbers[0]);
		}
	}

}
