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
            // Display text that tells user to type an integer in between 0 and 100.
            Console.WriteLine("Please enter an integer between 1 and 100.");
            // this variable will handle the user input
                string input = Console.ReadLine();
                // Declaring a variable to count the loop iterations
                int count = 1;
                    // WHILE Statement begins
                    while (count <= 2)
                    {
                        Console.WriteLine("You have entered" + input + "." + "This is the current integer value in the loop:" + count);
                    // Add one to count
                    count = count + 1;
                    }//end of while statement
        }
    }
}
