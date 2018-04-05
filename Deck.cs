// Next, create a class called "Deck"

// Give the Deck class a property called "cards" which is a list of 
// Card objects
// When initializing the deck make sure that it has a list of 52 
// unique cards as its "cards" property
// Give the Deck a reset method that resets the cards property to 
// the contain the original 52 cards

// Give the Deck a deal method that selects the "top-most" card, 
// removes it from the list of cards, and returns the Card
// Give the Deck a shuffle method that randomly reorders the deck's 
// cards

using System;
using System.Collections.Generic;

namespace batmanFluxx
{
    
    public class Deck
    {
        List<Card> cards = new List<Card>();
        
        public Deck() {
            this.buildDeck();

        }
        public void buildDeck() {
            string[] creeperName = {
                "The Riddler",
                "Catwoman",
                "Bane",
                "Poison Ivy",
                "The Joker",
                "The Penguin",
                "Harley Quinn",
                "Mr. Freeze",
                "Two-Face"
            };
        // string name;
            string[] keeperNameArray = {
                "Bruce Wayne",
                "Batman Cuffs", 
                "Batgirl", "Robin", 
                "Batmobile", 
                "Batarang", 
                "The Batcave", 
                "The Bank", 
                "Batcomputer", 
                "Commissioner Gordon", 
                "Alfred Pennyworth", 
                "Wayne Manor",
                "The Bat Signal",
                "Batman"
            };
            string[] goalNameArray = {
                "To the Batcave!",
                "Those Wonderful Toys",
                "I'll take Care of That, Sir...",
                "Batman Family",
                "To the Batpoles",
                "Utility Belt",
                "He Left Us a Signal",
                "Secretly His Daughter",
                "Stately Wayne Manor",
                "The Dynamic Duo",
                "To the Batmobile!",
                "He's a Billionaire",
                "Sidekicks",
                "I am the Night!",
                "With Some Help From Alfred",
                "Secret Tunnel",
                "The Joker Got Away",
                "Poison Ivy and Bane",
                "Black-Tie Bad Guys",
                "Mad Love",
                "Green with Villainy",
                "Cold Cash",
                "Riddle Me This, Batman...",
                "Rogues' Gallery",
                "Crime Spree",
                "Bank Robbery in Progress",
                "Gotham City Sirens",                
                "Backed Intro a Corner!",

            };

            //creeper before riddler:
            // "Bane","Poison Ivy","The Joker",

            //creepr after riddler: 
            // ,"Catwoman","The Penguin","Harley Quinn","Mr. Freeze","Two-Face"

            for (int i = 1; i <=2; i++) {
                // pull from creeper name array
                int cat_ID = 2;
                cards.Add(new Card(i, cat_ID, creeperName[i-1], "I am a rule!"));

            }
            // for (int i = 101; i<128; i++) {
                // pull from goal name array
            // }
            // for (int i = 1; i <= 14; i++) {
                //pull from keeper name array
                
                
                // for (int j = 0; j < suits.Length; j++) {
                    // cards.Add(new Card(suits[j], i));
                // }

            // }
        }

        public void reset() {
            cards.Clear(); 
            this.buildDeck();
        }
        public void bugCheck() {
            foreach (Card item in cards) {
                Console.WriteLine("hello worlds");
            }
        }
        public void shuffle() {
            int seed;
            Random rand = new Random();
            int deckCount = cards.Count;
            
            while (deckCount > 1) {
                deckCount--;
                seed = rand.Next(deckCount + 1);
                Card split = cards[seed];
                cards[seed] = cards[deckCount];
                cards[deckCount] = split;
            }
        }

        public Card topCard() {
            Console.WriteLine("Top card before deal is the {0}",cards[0].name);
            Card temp = cards[0];
            cards.RemoveAt(0);
            Console.WriteLine("Dealt card is the {0}", temp.name);
            Console.WriteLine("Top card after deal is the {0}",cards[0].name);
            Console.WriteLine($"Top card's rule is {cards[0].rule}");
            return temp;
        }

        public void topFive() {
            Console.WriteLine("********************");
            Console.WriteLine("The top 5 cards in the deck are: ");
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(cards[i]);
            }
        Console.WriteLine("********************");   
    }
}
}
