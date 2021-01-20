using System;

namespace Lab3_DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            string proceed = "y"; string userName;
            int input = 0;

            Console.Write("Hello, please enter your name: ");
            userName = Console.ReadLine();

            while (proceed == "y")
            {
                // Get user input for Length
                Console.Write($"\n{userName}, please enter a number betweeen 1 and 100: ");

                bool valid = false;
                while (!valid)
                {
                    if (int.TryParse(Console.ReadLine(), out input)) 
                    {
                        if (input >= 1 && input <= 100)
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.Write($"\nSorry {userName}, that was invalid.\nPlease enter a number betweeen 1 and 100: ");
                        }
                    }
                    else
                    {
                        Console.Write($"\nSorry {userName}, that was invalid.\nPlease enter a number betweeen 1 and 100: ");
                    }
                }

                if (input % 2 == 0)
                {
                    //The number entered is even

                    if (input < 25)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if (input > 25 && input < 61)
                    {
                        Console.WriteLine("Even.");
                    }
                    else
                    {
                        Console.WriteLine($"{input} Even.");
                    }                  
                }
                else
                {
                    //The number entered is odd
                    Console.WriteLine($"{input} Odd.");
                        if (input > 60)
                    {
                        Console.WriteLine($"{input} Odd.");
                    }
                }


                // Ask if user wants to continue
                Console.Write($"\n{userName}, Would you like to continue? (y/n) ");
                proceed = Console.ReadLine().ToLower();

            }

            Console.WriteLine($"\nThanks for playing {userName}.\nHope to see you again soon!");
            //Console.ReadLine();
        }
    }
}
