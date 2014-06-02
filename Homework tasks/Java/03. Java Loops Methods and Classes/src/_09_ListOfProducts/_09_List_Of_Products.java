package _09_ListOfProducts;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

//Problem 09 List of Products
//Create a class Product to hold products, which have name (string) and price (decimal number). Read from a text file named "Input.txt" a list of products. Each product will be in format name + space + price. You should hold the products in objects of class Product. Sort the products by price and write them in format price + space + name in a file named "Output.txt". Ensure you close correctly all used resources. 

public class _09_List_Of_Products {

	// Thanks again to the guys from the SoftUni's forum where there were many
	// solutions on how to create the additional class.
	public static void main(String[] args) {
		String fileproducts = "src/Input.txt";
		String[] splittedInput = new String[1];
		List<Product> products = new ArrayList<>();
		String input = null;
		try (BufferedReader fileReader = new BufferedReader(new FileReader(
				fileproducts))) {

			while (true) {

				input = fileReader.readLine();
				if (input == null) {
					break;
				}
				splittedInput = input.split(" ");
				products.add(new Product(splittedInput[0], Double
						.parseDouble(splittedInput[1])));
			}
			Collections.sort(products);
			
			try (BufferedWriter writeFile = new BufferedWriter(new FileWriter(
					"src/Output.txt"));) {
				for (Product product : products) {
					writeFile.write(product.showName() + " "
							+ product.showPrice() + "\n");
				}

			}

		} catch (IOException e) {
			System.out.println("There is an error!");
			e.printStackTrace();
		}
	}
}
