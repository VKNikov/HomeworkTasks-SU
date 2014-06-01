import java.util.HashSet;
import java.util.Random;
import java.util.Scanner;
import java.util.Set;

//Problem 6. Random Hands of 5 Cards
//Write a program to generate n random hands of 5 different cards form a standard suit of 52 cards.

public class _06_Random_Hands_Of_5_Cards {

	public static void main(String[] args) {
		System.out.println("This program generates a random hands of 5 different cards(from 53 total).");
		System.out.println("Please enter how many different hands do you want to be printed:");
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int numberOfHands = input.nextInt();
		
		Random rnd = new Random();
		String [] cards = {"2","3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		String[] suits = {"♣", "♦", "♥", "♠"};
		
		//Populates the hashset with "random" cards.
		for (int i = 0; i < numberOfHands; i++) {
			Set<String> hand = new HashSet<>();
			boolean fullSet = false;
			while (!fullSet) {
				int randomCard = rnd.nextInt(13);
				int randomSuit = rnd.nextInt(3);
				hand.add(cards[randomCard] + suits[randomSuit]);

				if (hand.size() == 5) {
					fullSet = true;
				}
			}
			//Prints the hand
			for (String string : hand) {
				System.out.print(string + " ");
			}
			System.out.println();
		}
	}

}
