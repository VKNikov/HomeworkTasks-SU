import java.util.Scanner;

/*Problem 5. Angle Unit Converter (Degrees ↔ Radians)
Write a method to convert from degrees to radians. Write a method to convert from radians to degrees. You are given a number n and n queries for conversion. Each conversion query will consist of a number + space + measure. Measures are "deg" and "rad". Convert all radians to degrees and all degrees to radians. Print the results as n lines, each holding a number + space + measure. Format all numbers with 6 digit after the decimal point.*/

public class _05_AngleUnitConverter {

	public static void main(String[] args) {
		System.out.println("This program will convert radians to degrees and vice versa.");
		System.out.println("Please enter enter how many queries you will make:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		
		for (int i = 0; i < number; i++) {
			double numberToConvert = input.nextInt();
			String conversionTo = input.nextLine();
			
			//I did it this way so I can make the formatting (new line) look better.
			if (i != number - 1) {
				if (conversionTo.equals(" rad")) {
					System.out.println();
					convertToDegrees(numberToConvert);
					
				} else {
					System.out.println();
					convertToRadians(numberToConvert);
				}
			} else {
				if (conversionTo.equals(" rad")) {
					convertToDegrees(numberToConvert);
					
				} else {
					convertToRadians(numberToConvert);
				}
			}			
		}
	}

	//Method for converting degrees to radians
	private static void convertToRadians(double numberToConvert) {
		numberToConvert = Math.toRadians(numberToConvert);
		System.out.printf("%.6f %s", numberToConvert, "rad");
	}

	//Method for converting radians to degrees
	private static void convertToDegrees(double numberToConvert) {
		numberToConvert = Math.toDegrees(numberToConvert);
		System.out.printf("%.6f %s", numberToConvert, "deg");
	}

}
