namespace Edee_Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mainLoop = true; //The main loop

            Console.WriteLine("************************************");
            Console.WriteLine("Welcome to Programming 2 - Assignment 6 - Winter 2025\n");
            Console.WriteLine("Created by CHRISTEL 6250046 on April 28th 2025");
            Console.WriteLine("************************************");

            while (mainLoop)
            {
                Console.WriteLine("\n");

                Console.WriteLine("Please choose below:\n");
                Console.WriteLine("1- Add Winner to Leaderboard");
                Console.WriteLine("2- Delete Entry from Leaderboard");
                Console.WriteLine("3- Save Leaderboard to File");
                Console.WriteLine("4- Load Leaderboard from File");
                Console.WriteLine("5- Clear Leaderboard");
                Console.WriteLine("6- Quit\n");
                Console.Write("Choice: ");

                byte menuChoice = MenuChoiceValidation(); //Processing the user's choice

                //The main switch loop depending on the previous user input:
                switch (menuChoice)
                {
                    case 1:
                    break;

                    case 2:
                    break;

                    case 3:
                        mainLoop = false;
                    break;
                }
            }
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