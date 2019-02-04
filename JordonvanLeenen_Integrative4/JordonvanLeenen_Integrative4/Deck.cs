using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordonvanLeenen_Integrative4
{
    class Deck
    {
        private Card[] deck;
        private int currentCard;
        private const int numOfCards = 52;
        private Random randoNum;

        public Deck()
        {
            string[] faces = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 15 };
            deck = new Card[numOfCards];
            currentCard = 0;
            randoNum = new Random();
            for (int count = 0; count < deck.Length; count++)
                deck[count] = new Card(faces[count % 11], suits[count / 13])
        }
    }
}
