using System;

namespace CCC
{

    public abstract class J12018
    {

        public static void Execute()
        {

            // Display instructions
            Console.WriteLine("Enter four numbers, press ENTER after each number:");

            // Get the four numbers of the phone number
            int number1Input = Convert.ToInt32(Console.ReadLine());
            int number2Input = Convert.ToInt32(Console.ReadLine());
            int number3Input = Convert.ToInt32(Console.ReadLine());
            int number4Input = Convert.ToInt32(Console.ReadLine());

            // Display the complete series of numbers
            Console.WriteLine("You entered " + number1Input + number2Input + number3Input + number4Input);

            // Check if the number is a telemarketer
            if (number1Input > 7 && number2Input == number3Input && number4Input > 7)
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
