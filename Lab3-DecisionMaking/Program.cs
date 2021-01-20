using System;

namespace Lab3_DecisionMaking
{
    /*
    Author:   Jeffrey Wohlfield
    Date  01-20-2021
    This program will prompt for their name and a number between 1 and 100.

    Build Specifications:
    Given an integer entered by a user, perform the following conditional actions:
        If the integer is odd, print the number entered and “Odd.”
        If the integer entered is even and in the inclusive range of 2 to 25,
        print “Even and less than 25.”
        If the integer entered is even and in the inclusive range of 26 to 60,
        print “Even.”
        If the integer entered is even and greater than 60, print the number
        entered and “Even”.
        If the integer entered is odd and greater than 60, print the number
        entered and “Odd.”
    */
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
                        
                        // I only do this because of how I interpreted the instructions                        
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
