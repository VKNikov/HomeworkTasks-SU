import java.util.Scanner;

//Problem 8. Count of Bits One
//Write a program to calculate the count of bits 1 in the binary representation of given integer number n. 

public class _07_CountOfBitsOne {

	public static void main(String[] args) {
		System.out.println("This program counts the bits set to 1 in a given integer number.");
		System.out.println("Please enter an integer number:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		int counter = Integer.bitCount(number);
		System.out.printf("The number of bits is: %d", counter);
	}

}
