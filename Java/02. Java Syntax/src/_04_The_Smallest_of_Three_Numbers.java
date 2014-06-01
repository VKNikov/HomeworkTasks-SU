import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

//Problem 5. The Smallest of 3 Numbers
//Write a program that finds the smallest of three numbers. 

public class _04_The_Smallest_of_Three_Numbers {

	public static void main(String[] args) {
		System.out.println("This program finds the smallest of three numbers");
		System.out.println("Please enter the first number:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		double first = input.nextDouble();
		System.out.println("Please enter the second number:");
		double second = input.nextDouble();
		System.out.println("Please enter the third number:");
		double third = input.nextDouble();
		
		List<Double> numbersCombined = new ArrayList<>(Arrays.asList(first, second, third));
		numbersCombined.add(5.5);

		Collections.sort(numbersCombined);
		
		DecimalFormat formatedNumber = new DecimalFormat("0.#");
		
		System.out.printf("The smallest of the three numbers is %s", formatedNumber.format(numbersCombined.get(0)));

	}

}
