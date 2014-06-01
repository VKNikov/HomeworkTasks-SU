//Problem 6. Print the Current Date and Time
//Create a simple Java program CurrentDateTime.java to print the current date and time. Submit the Java class CurrentDateTime as part of your homework.

import java.time.LocalDateTime;

public class _06_Print_The_Current_Date_Time {

	public static void main(String[] args) {
		System.out.println("This program prints the current Date and Time.");
		LocalDateTime currentTime = LocalDateTime.now();
		System.out.println(currentTime);

	}

}
