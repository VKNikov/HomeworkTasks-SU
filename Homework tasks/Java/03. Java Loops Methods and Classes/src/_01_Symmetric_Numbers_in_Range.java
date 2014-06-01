import java.util.Scanner;

//Problem 1. Symmetric Numbers in Range
//Write a program to generate and print all symmetric numbers in given range [start…end]. A number is symmetric if its digits are symmetric toward its middle. For example, the numbers 101, 33, 989 and 5 are symmetric, but 102, 34 and 997 are not symmetric.

public class _01_Symmetric_Numbers_in_Range {

	public static void main(String[] args) {
		System.out.println("This program generates and prints all symetric numbers in a given range");
		System.out.println("Please enter the starting point of the range:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		
		int startNumber = input.nextInt();
		System.out.println("Please enter the ending point of the range:");
		int lastNumber = input.nextInt();
		
		for (int i = startNumber; i <= lastNumber; i++) {
			String numberAsString = Integer.toString(i);
			boolean equal = true;
			
			for (int j = 0; j < numberAsString.length()/2; j++) {
				
				if (numberAsString.charAt(j) != numberAsString.charAt(numberAsString.length() - (j + 1))) {
					equal = false;
				}
			}
			
			if (equal) {
				System.out.println(numberAsString);
			}
		}
	}
}
