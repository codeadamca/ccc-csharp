using System;

namespace CCC
{

    public abstract class J22018
    {

        public static void Execute()
        {

            // Display instructions
            Console.WriteLine("Enter the number of parking spots:");

            // Get user input for the number of parking spots
            int parkingSpotsInput = Convert.ToInt32(Console.ReadLine());

            // More instructions
            Console.WriteLine("Enter the status of the parking spots (C for car and . .for empty):");

            string day1Input = Console.ReadLine();
            string day2Input = Console.ReadLine();

            // Track the number of occupied spots
            int spots = 0;

            // Check which spots were occupied both days
            for (int i = 0; i < parkingSpotsInput; i++)
            {
                if (day1Input.Substring(i,1) == "C" && day2Input.Substring(i,1) == "C")
                {
                    spots++;
                }
            }

            // Display results
            Console.WriteLine("There were " + spots + " parking spots occupied on both days!");

        }

    }

}
