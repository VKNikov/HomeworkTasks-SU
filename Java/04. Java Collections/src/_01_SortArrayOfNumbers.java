import java.util.Arrays;
import java.util.Scanner;

//Problem 1. Sort Array of Numbers
//Write a program to enter a number n and n integer numbers and sort and print them. Keep the numbers in array of integers: int[].

public class _01_SortArrayOfNumbers {

	public static void main(String[] args) {
		System.out.println("This program sorts and prints an array of integer numbers.");
		System.out.println("Please enter how many integers you will like to sort and then enter the integers.");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		int[] allNumbers = new int[number];
		
		for (int i = 0; i < allNumbers.length; i++) {
			allNumbers[i] = input.nextInt();
		}
		
		Arrays.sort(allNumbers);
		
		System.out.println("The sorted array looks like this:");
		
		for (int i : allNumbers) {
			System.out.print(i + " ");
		}
	}

}
