using System;

namespace batmanFluxx
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck drawDeck = new Deck();
            drawDeck.shuffle();
            drawDeck.topCard();
        }
    }
}
