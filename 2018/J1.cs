using System;

namespace CCC
{

    public abstract class J12018
    {

        public static void Execute()
        {

            // Display instructions
            Console.WriteLine("Enter four numbers, press ENTER after each number:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            int userInput4 = Convert.ToInt32(Console.ReadLine());

            // Display the complete series of numbers
            Console.WriteLine("You entered " + userInput1 + userInput2 + userInput3 + userInput4);

            // Check if the number is a telemarketer
            if (userInput1 > 7 && userInput2 == userInput3 && userInput4 > 7)
            {
                Console.WriteLine("Ignore");
            }
            else
            {
                Console.WriteLine("Answer");
            }

        }

    }

}
