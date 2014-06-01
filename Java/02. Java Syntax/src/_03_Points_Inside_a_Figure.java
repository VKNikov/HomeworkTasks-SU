import java.util.Scanner;

//Problem 4. Points inside a Figure
//Write a program to check whether a point is inside or outside of the figure below. The point is 
//given as a pair of floating-point numbers, separated by a space. Your program should print 
//"Inside" or "Outside".

public class _03_Points_Inside_a_Figure {

	public static void main(String[] args) {
		System.out.println("Please enter values for a point (x and y)");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		float x = input.nextFloat();
		float y = input.nextFloat();
		
		if ((y >= 6 && y <= 13.5) && (x >= 12.5 && x <= 22.5)) {
			if ((y > 8.5 && y < 13.5) && (x > 17.5 && x < 20)) {
				System.out.println("Outside");
			}
			
			System.out.println("Inside");
		} else {
			System.out.println("Outside");
		}

	}

}
