namespace Edee_Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mainLoop = true; //The main loop

            Console.WriteLine("************************************");
            Console.WriteLine("Welcome to Programming 2 - Assignment 4 - Winter 2025\n");
            Console.WriteLine("Created by CHRISTEL 6250046 on March 18th 2025");
            Console.WriteLine("************************************");
        }


        //Suit enum
        enum Suit
        {
           Hearts, 
           Diamonds, 
           Clubs, 
           Spades
        }

        //Rank enum
        enum Rank
        {
            Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Jack, Queen, King, Ace
        }
    }
}