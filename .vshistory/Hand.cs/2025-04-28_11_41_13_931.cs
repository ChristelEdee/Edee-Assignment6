using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edee_Assignment6
{
    internal class Hand
    {
        private List<Card> cards;

        //Property:
        public int Size
        {
            get
            {
                return cards.Count;
            }
        }

        //Constructor:
        public Hand(int handSize)
        {
            cards = new List<Card>();
            Random random = new Random();

            for(int i = 0; i < handSize; i++)
            {
                Rank rank = (Rank)random.Next(2, 15); //Choosing random rank from the Rank enum
                Suit suit = (Suit)random.Next(0, 4); //Choosing random suit from the Suit enum
                cards[i] = new Card(rank, suit); //Adding the created card to the hand
            }
        }


        //Method:
        public void Sort(bool increasingOrder)
        {
            if(increasingOrder == true)
            {

            }
            else
            {

            }
        }

        //Override Methods
        public override string ToString()
        {
            string str = " ";

            foreach(Card card in cards)
            {
               str += $"{card.ToString()}\n";
            }

            return str;
        }
    }
}
