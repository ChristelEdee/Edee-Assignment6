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

        //Overload Methods
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
            int hash = 17;


        }
    }
}
