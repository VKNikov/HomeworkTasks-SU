import java.util.Scanner;

//Problem 7. Formatting Numbers
//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned.

public class _06_Formatting_Numbers {

	public static void main(String[] args) {
		System.out.println("This program reads three numbers, an integer a, a floating point b and a floating point c and prints them in 4 virtual columns.");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		
		System.out.println("Please enter value for integer a:");
		int a = input.nextInt();
		
		System.out.println("Please enter value for a floating point number b");
		float b = input.nextFloat();
		
		System.out.println("Please enter value for a floating point number c");
		float c = input.nextFloat();
		
		String aAsHex = String.format("%x", a);
		String aAsBinaryString = Integer.toBinaryString(a);
		int aAsBinary = Integer.parseInt(aAsBinaryString);
		
		if (c % 1 == 0) {
			System.out.printf("|%1$-10s|%2$010d|%3$10.2f|%4$-10.0f|", aAsHex.toUpperCase(), aAsBinary, b, c);
		} else {
			System.out.printf("|%1$-10s|%2$010d|%3$10.2f|%4$-10.3f|", aAsHex.toUpperCase(), aAsBinary, b, c);
		}
		
		

	}
}
