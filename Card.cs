// TODO:
// Create a class called "Card"

// Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). This "val" should be a String
// Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds)
// Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers


using System;

namespace batmanFluxx
{   
    public class Card
    {
        public string name; //this is what the players see

        int id; //how we reference for conditions check
        int category_ID; //cat 1 for kprs, cat 2 for crprs, cat 3 for goals
        Boolean active_State; //true if in list(aka on table), false in either decks or hands
        string rule; //reworked into logic later
        public Card(string suit, int val) {
            // this.suit = suit;
            // this.val = val;
         
            // if (val == 1) {
            //     this.face = "Ace";
            // }
            // else if (val == 11) {
            //     this.face = "Jack";
            // }
            // else if (val == 12) {
            //     this.face = "Queen";
            // }
            // else if (val == 13) {
            //     this.face = "King";
            // }
            // else {
            //     this.face = val.ToString();
            // }
            // this.suitVal = $"{face} of {suit}";
            // this.suitVal = face + " of " + suit;
        }
        
    }
}


