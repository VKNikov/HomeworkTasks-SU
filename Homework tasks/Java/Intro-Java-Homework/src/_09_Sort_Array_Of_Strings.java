import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

//Problem 9. * Sort Array of Strings
//Write a program that enters from the console number n and n strings, then sorts them alphabetically and prints them. Note: 
//	you might need to learn how to use loops and arrays in Java (search in Internet). 
	
public class _09_Sort_Array_Of_Strings {

	public static void main(String[] args) {
		System.out.println("This program reads from the console number n and then n strings, then sorts them alphabetically and prints them");
		@SuppressWarnings("resource")
		Scanner userinput = new Scanner(System.in);
		int n = userinput.nextInt();
		String inputAsString;
		List<String> sortedInput = new ArrayList<String>();
		
		for (int i = 0; i <= n; i++) {
			inputAsString = userinput.nextLine();
			sortedInput.add(inputAsString);
		}
		Collections.sort(sortedInput);
		
		for (String word : sortedInput) {
			System.out.println(word);
		}
	}

}
