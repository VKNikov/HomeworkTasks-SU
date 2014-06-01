import java.text.MessageFormat;
import java.util.Scanner;

//Problem 2. Rectangle Area
//Write a program that enters the sides of a rectangle (two integers a and b) and calculates and prints 
//the rectangle's area. 

public class _01_Rectangle_Area {

	public static void main(String[] args) {
		System.out.println("This program reads the sides of a rectangle (a and b), "
				+ "calculates and prints it's area");
		System.out.println("Please enter value for a");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		System.out.println("Please enter value for b");
		int b = input.nextInt();
		System.out.println(MessageFormat.format("The area of the rectangle with sides {0} and {1} is: {2}", a, b, a*b));

	}

}
