import java.awt.geom.Path2D;
import java.util.Scanner;

//Problem 10. ** Points inside the House
//Write a program to check whether a point is inside or outside the house below. The point is given as a pair of floating-point numbers, separated by a space. Your program should print "Inside" or "Outside". 

public class _09_PointsInsideHouse {
	

	public static void main(String[] args) {
		System.out.println("Please enter the point's coordinates (x and y)");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		
		double x = input.nextDouble();
		double y = input.nextDouble();
		
		isInside(x, y);

	}
	//This method draws the polygon and checks if the inputed point is inside it.
	private static void isInside(double x, double y) {
		double[] xPoints= {17.5, 12.5, 12.5, 17.5, 17.5, 20, 20, 22.5, 22.5};
		double[] yPoints = {3.5, 8.5, 13.5, 13.5, 8.5, 8.5, 13.5, 13.5, 8.5};

		Path2D figure  = new Path2D.Double();
		figure.moveTo(xPoints[0], yPoints[0]);
		
		for (int i = 0; i < yPoints.length; i++) {
			figure.lineTo(xPoints[i], yPoints[i]);
		}
			
		figure.closePath();
		
		if (figure.contains(x, y)) {
			System.out.println("Inside");;
		} else {
			System.out.println("Outside");
		}
		
	}

}
