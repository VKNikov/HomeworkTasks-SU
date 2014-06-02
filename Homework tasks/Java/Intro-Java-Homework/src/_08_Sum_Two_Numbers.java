import java.text.MessageFormat;
import java.util.Scanner;

public class _08_Sum_Two_Numbers {

	public static void main(String[] args) {

		System.out.println("This program reads two integers from the console, calculates and prints their sum");
		@SuppressWarnings("resource")
		Scanner userinput = new Scanner(System.in);
		int firstNumber = userinput.nextInt();
		int secondNumber = userinput.nextInt();
		
		//Here I use println with MessageFormat instead of printf. because the syntax is more similar to C# and I like it.
		System.out.println(MessageFormat.format("The sum of the integer {0} and integer {1} is: {2}", firstNumber, secondNumber, firstNumber + secondNumber));

	}

}
