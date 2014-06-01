import java.util.Scanner;

//Problem 9. * Count of Equal Bit Pairs
//Write a program to count how many sequences of two equal bits ("00" or "11") can be found in the binary representation of given integer number n (with overlapping). 

public class _08_Count_Of_Equal_Bit_Pairs {

	public static void main(String[] args) {
		System.out.println("This program counts how many sequences of two equal bits (00 or 11) can be found in the binary representation of given integer number (with overlapping)");
		System.out.println("Please enter an integer number:");
		Scanner input = new Scanner(System.in);
		int counter = countingSequenceofEqualBits(input);
		
		System.out.printf("Count: %d", counter);
	}

	//Method for counting the equal sequences
	private static int countingSequenceofEqualBits(Scanner input) {
		int number = input.nextInt();
		int counter = 0;
		
		while (number != 0) {
			int firstBitValue = number & 1;
			int secondBitValue = (number >>> 1) & 1;
			
			if (firstBitValue == secondBitValue) {
				counter ++;
				
				
			} 
			
			number >>>= 1;
		}
		return counter;
	}

}
