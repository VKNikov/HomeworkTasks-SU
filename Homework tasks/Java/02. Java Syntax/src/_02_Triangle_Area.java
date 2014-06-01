import java.text.MessageFormat;
import java.util.Scanner;

//Problem 3. Triangle Area
//Write a program that enters 3 points in the plane (as integer x and y coordinates), calculates and prints 
//the area of the triangle composed by these 3 points. Round the result to a whole number. In case the 
//three points do not form a triangle, print "0" as result. 

public class _02_Triangle_Area {

	public static void main(String[] args) {
		System.out.println("This program calculates and prints the area of a triangle composed by 3 points.");
		System.out.println("Please enter the coordinates for the first point(x and y:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		double ax = input.nextDouble();
		double ay = input.nextDouble();
		
		System.out.println("Please enter the coordinates for the second point(x and y:");
		double bx = input.nextDouble();
		double by = input.nextDouble();
		
		System.out.println("Please enter the coordinates for the third point(x and y)");
		double cx = input.nextDouble();
		double cy = input.nextDouble();
		
		double area = Math.abs(((ax *(by - cy)) + (bx * (cy - ay))+ (cx *(ay - by))) / 2);
		
		System.out.println(MessageFormat.format("The area of the triangle is: {0}", (int)area));

	}

}
