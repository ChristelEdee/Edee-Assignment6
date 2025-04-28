namespace Edee_Assignment6
{
    //Suit enum
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    //Rank enum
    public enum Rank
    {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Jack, Queen, King, Ace
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            bool mainLoop = true; //The main loop
            Hand hand = null; //Hand object

            Console.WriteLine("************************************");
            Console.WriteLine("Welcome to Programming 2 - Assignment 6 - Winter 2025\n");
            Console.WriteLine("Created by CHRISTEL 6250046 on April 28th 2025");
            Console.WriteLine("************************************");

            while (mainLoop)
            {
                Console.WriteLine("\n");

                //Displaying hand after every iteration of the main loop (Will display message if hand hasn't been created)
                if (hand == null)
                    Console.WriteLine("No hand to display.\n");
                else
                    Console.WriteLine($"{hand}\n");

                //MAIN MENU
                Console.WriteLine("Please choose below:\n");
                Console.WriteLine("1- Create Hand");
                Console.WriteLine("2- Sort Hand");
                Console.WriteLine("3- Quit\n");
                Console.Write("Choice: ");

                byte menuChoice = MenuChoiceValidation(); //Processing the user's choice

                //The main switch loop depending on the previous user input:
                switch (menuChoice)
                {
                    case 1:
                        CreateHand(ref hand);
                    break;

                    case 2:
                        if (hand == null)
                        {
                            Console.WriteLine("\nERROR: Hand not yet created.");
                            break;
                        }
                        else
                            SortHand(ref hand);
                    break;

                    case 3:
                        mainLoop = false;
                    break;
                }
            }

            Console.ReadLine();
        }


        static void CreateHand(ref Hand hand)
        {
            //Asking user for the number of cards in the hand
            Console.Write("How many cards would you like in the hand? (3-12): ");
            byte cardsInHand = CardsInHandValidation();

            //Creating the hand using the constructor
            hand = new Hand(cardsInHand);
        }

        static void SortHand(ref Hand hand)
        {
            bool isIncreaseOrder;

            //Asking user for the sorting order
            Console.Write("Do you want to sort the hand in an INCREASING order or a DECREASING order?: ");
            string order = OrderValidation();
        }

        //Validation methods:
        static byte MenuChoiceValidation()
        {
            const byte MAX_MENU_CHOICE = 3; //Last choice for main menu
            const byte MIN_CHOICE_NUM = 1;

            byte userInput;
            bool successfulConversion;

            successfulConversion = byte.TryParse(Console.ReadLine(), out userInput);

            while (successfulConversion == false || userInput > MAX_MENU_CHOICE || userInput < MIN_CHOICE_NUM)
            {
                Console.Write($"What you entered was not a valid choice. Try again: ");
                successfulConversion = byte.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;
        }
        static byte CardsInHandValidation()
        {
            const byte MIN_NUM = 3;
            const byte MAX_NUM = 12;

            byte userInput;
            bool successfulConversion;

            successfulConversion = byte.TryParse(Console.ReadLine(), out userInput);

            while (successfulConversion == false || userInput < MIN_NUM || userInput > MAX_NUM)
            {
                Console.Write($"What you entered wasn't valid. Try again: ");
                successfulConversion = byte.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;
        }

        static string OrderValidation()
        {
            string[] validAnswers = { "Increasing", "increasing", "Decreasing", "decreasing" };

            string userInput = Console.ReadLine(); //Reading from console

            //Outputting error message everytime an invalid answer is inputted:
            while (!validAnswers.Contains(userInput)) 
            {
                Console.Write("What you entered wasn't valid. Try again: ");
                userInput = Console.ReadLine();
            }

            return userInput;
        }
    }
}