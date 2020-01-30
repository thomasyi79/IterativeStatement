/* Author: Thomas Yi
 * Date Created: 1/29/2020
 * Description: Iterative Statement for Deliverable 2
 */
using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.Write("Enter an Integer value between 1 and 100 to execute an iterative statement: ");
            //use try and catch to prevent any value type other than Int.
            try
            {
                //gather data from user
                string input = Console.ReadLine();
                // parse string into int.
                int value_of_input = int.Parse(input);
                // use if statement to limit input to 1-100
                if (value_of_input >= 1 && value_of_input <= 100)
                    // use for loop to perform the iteration and display the messages.
                    for (int i = 1; i <= value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + ". " +
                            "This is the current integer value in the loop: " + i.ToString());
                    }
                //display messages when user enters values outside of limits between 1-100
                else
                    Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                // Pause the program and await the user to press a key to end the program
                Console.ReadKey(true);
            }
            catch
            {
                //display messages when user enters any other data type other than int
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                // Pause the program and await the user to press a key to end the program
                Console.ReadKey(true);
            }
        }
    }
}
