import java.text.MessageFormat;
import java.util.Scanner;

//Problem 7. Sum Two Numbers
//Write a program SumTwoNumbers.java that enters two integers from the console, calculates and prints their sum. 
//Search in Internet to learn how to read numbers from the console. 

public class _07_Sum_Two_Numbers {

	public static void main(String[] args) {
		System.out.println("This program reads two integers from the console, calculates and prints their sum");
		@SuppressWarnings("resource")
		Scanner userInput = new Scanner(System.in);
		int firstNumber = userInput.nextInt();
		int secondNumber = userInput.nextInt();
		
		//Here I use println with MessageFormat instead of printf. because the syntax is more similar to C# and I like it.
		System.out.println(MessageFormat.format("The sum of the integer {0} and integer {1} is: {2}", firstNumber, secondNumber, firstNumber + secondNumber));

	}

}
