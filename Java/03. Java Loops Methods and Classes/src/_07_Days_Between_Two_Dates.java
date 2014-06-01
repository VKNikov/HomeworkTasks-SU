import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

//Problem 7. Days between Two Dates
//Write a program to calculate the difference between two dates in number of days. The dates are entered at two consecutive lines in format day-month-year. Days are in range [1…31]. Months are in range [1…12]. Years are in range [1900…2100]. 

public class _07_Days_Between_Two_Dates {

	public static void main(String[] args) {
		System.out
				.println("This program will calculate and print the difference between two dates in number of days");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("d-MM-yyyy");
		LocalDate firstDate = LocalDate.parse(input.next(), formatter);
		LocalDate secondDate = LocalDate.parse(input.next(), formatter);

		calculateDifferenceInDays(firstDate, secondDate);

	}
	//Method for calculating the difference
	private static void calculateDifferenceInDays(LocalDate firstDate,
			LocalDate secondDate) {
		long difference = ChronoUnit.DAYS.between(firstDate, secondDate);
		System.out.println(difference);
	}

}
