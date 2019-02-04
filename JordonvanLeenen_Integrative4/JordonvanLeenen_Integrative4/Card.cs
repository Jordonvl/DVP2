using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordonvanLeenen_Integrative4
{
    class Card
    {
        private string face;
        private string suit;
        private int value;

        public Card(string cardFace, string cardSuit, int cardValue)
        {
            face = cardFace;
            suit = cardSuit;
            value = cardValue;
        }

        public override string ToString()
        {
            return face + " of " + suit + " value " + value;
        }
    }
}
