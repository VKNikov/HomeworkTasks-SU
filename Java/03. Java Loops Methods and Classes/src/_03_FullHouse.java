/*Problem 3. Full House
In most Poker games, the "full house" hand is defined as three cards of the same face + two cards of the same face, other than the first, regardless of the card's suits. The cards faces are "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" and "A". The card suits are "♣", "♦", "♥" and "♠". Write a program to generate and print all full houses and print their number.

*/public class _03_FullHouse {

	//Thanks to LittleNinja from the SoftUni's forum!
	public static void main(String[] args) {
		System.out.println("This program will print all full house hands in poker.");
		
		String [] cards = {"2","3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		char[] suits = {'♣', '♦', '♥', '♠'};

		int counter = 0;
		
		for (int i = 0; i < cards.length; i++) {
			for (int j = 0; j < cards.length; j++) {
				for (int k =0; k < suits.length; k++) {
					for (int l = k + 1; l < suits.length; l++) {
						for (int m = l + 1; m< suits.length; m++) {
							for (int n = 0; n < suits.length; n++) {
								for (int o = n + 1; o < suits.length; o++) {
									if (i != j) {
										System.out.printf(
										"\n%s%c %s%c %s%c %s%c %s%c\n",
										cards[i], suits[k], cards[i],
										suits[m], cards[i], suits[l],
										cards[j], suits[n], cards[j],
										suits[o]);
										counter++;
									}
								}
							}
						}
					}
				}
			}
		}
		System.out.printf("\n" + counter + " full houses" + "\n");
	}
}
