import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

//Problem 8. Sum Numbers from a Text File
//Write a program to read a text file "Input.txt" holding a sequence of integer numbers, each at a separate line. Print the sum of the numbers at the console. Ensure you close correctly the file in case of exception or in case of normal execution. In case of exception (e.g. the file is missing), print "Error" as a result.

public class _08_Sum_Numbers_From_Textfile {

	public static void main(String[] args) {
		System.out.println("This program reads a file with name Input.txt (placed in the source folder) and if there is a file with numbers in it will print the sum of the numbers at the console");
		String fileInput = "src/Input.txt";
		List<Integer> numbers = new ArrayList<>();
		int sum = 0;
		
		try (BufferedReader fileReader = new BufferedReader(new FileReader(fileInput));){
			while (true) {
				String incommingLine = fileReader.readLine();
				if (incommingLine == null) {
					for (Integer integer : numbers) {
						sum += integer;
					}
					System.out.println(sum);
					break;
				}
				numbers.add(Integer.parseInt(incommingLine));
				
			}
			
		} catch (IOException e) {
			System.out.println("Error");
		}
	}

}
