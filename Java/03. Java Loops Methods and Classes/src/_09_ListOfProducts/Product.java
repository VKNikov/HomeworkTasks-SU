package _09_ListOfProducts;


public class Product implements Comparable<Product>{
	private String name;
	private double price;
	
	public Product(String name, double price){
		this.name = name;
		this.price = price;
	}
	
	public String showName(){
		return name;
	}
	
	public double showPrice(){
		return price;
	}
	
	public int compareTo(Product compareList) {
		 
		double otherPrice = ((Product) compareList).showPrice(); 
 
		if(this.price>otherPrice) return 1;
		else
		if(this.price==otherPrice) return 0;
		return -1;
	}	
}
