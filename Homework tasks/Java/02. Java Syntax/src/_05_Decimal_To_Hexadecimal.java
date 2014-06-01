import java.util.Scanner;

//Problem 6. Decimal to Hexadecimal
//Write a program that enters a positive integer number num and converts and prints it in hexadecimal form. You may use some built-in method from the standard Java libraries.

public class _05_Decimal_To_Hexadecimal {

	public static void main(String[] args) {
		System.out.println("This program converts a positive integer number to its hexadecimal form.");
		System.out.println("Please enter a positive integer number.");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		String hexResult = Integer.toHexString(num);
		
		System.out.printf("The hexadecimal representation of your number is: %s", hexResult.toUpperCase());
		//System.out.printf("%x", num);
	}

}
