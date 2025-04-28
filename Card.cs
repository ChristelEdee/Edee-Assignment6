using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edee_Assignment6
{
  
    internal class Card
    {
        private Rank _rank;
        private Suit _suit;

        //Properties:
        public Rank Rank
        {
            get { return _rank; }
        }

        public Suit Suit
        {
            get { return _suit; }
        }


        //Constructor:
        public Card(Rank rank, Suit suit)
        {
            _rank = rank;
            _suit = suit;
        }

        //Override Methods
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }

        public override bool Equals(object obj)
        {
            if(obj != null || GetType() == obj.GetType())
            {
                return false;
            }

            Card otherObject = (Card)obj;

            return otherObject.Rank == this.Rank && otherObject.Suit == this.Suit;
        }

        public override int GetHashCode()
        {
            //Starting with a prime number
            int hash = 17;

            //Combining the hash codes of the fields (no need for null check)
            hash = hash * 31 + Rank.GetHashCode();
            hash = hash * 31 + Suit.GetHashCode();

            return hash;
        }


        //Operators:
        public static bool operator > (Card card1, Card card2)
        {
            bool boolean;

            //Only comparing the ranks if the suits are the same
            if(card1.Suit == card2.Suit)
                boolean = card1.Rank > card2.Rank;
            else
                boolean = (int)card1.Suit > (int)card2.Suit;

            return boolean;
        }
        public static bool operator >=(Card card1, Card card2)
        {
            bool boolean;

            if (card1.Suit == card2.Suit)
                boolean = card1.Rank >= card2.Rank;
            else
                boolean = (int)card1.Suit >= (int)card2.Suit;

            return boolean;
        }
        public static bool operator < (Card card1, Card card2)
        {
            bool boolean;

            if (card1.Suit == card2.Suit)
                boolean = card1.Rank < card2.Rank;
            else
                boolean = (int)card1.Suit < (int)card2.Suit;

            return boolean;
        }
        public static bool operator <= (Card card1, Card card2)
        {
            bool boolean;

            if (card1.Suit == card2.Suit)
                boolean = card1.Rank <= card2.Rank;
            else
                boolean = (int)card1.Suit <= (int)card2.Suit;

            return boolean;
        }
        public static bool operator == (Card card1, Card card2)
        {
            bool boolean;

            if (card1.Suit == card2.Suit)
                boolean = card1.Rank == card2.Rank;
            else
                boolean = (int)card1.Suit == (int)card2.Suit;

            return boolean;
        }
        public static bool operator != (Card card1, Card card2)
        {
            bool boolean;

            if (card1.Suit == card2.Suit)
                boolean = card1.Rank != card2.Rank;
            else
                boolean = (int)card1.Suit != (int)card2.Suit;

            return boolean;
        }

    }
}
