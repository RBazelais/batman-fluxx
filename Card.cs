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
        public string rule; //reworked into logic later
        public Card(int id, int category_ID, string name, string rule) {
            this.id = id;
            this.category_ID= category_ID;
            this.name = name;
            this.active_State = false;
            this.rule = rule;
        }

        public void rulesChoice(int category_ID, int id) {
            switch (category_ID) 
            {
                case 1:
                    //keepers
                    break;
                case 2:
                    //creepers
                    //list.Add(card)
                    //Player.draw(Deck drawDeck);
                    break;
                case 3:
                    //goals
                    break;
                default: 
                    Console.WriteLine("Cheater!");
                    break;

            }
        }
        
    }
}


