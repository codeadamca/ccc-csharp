using System;

namespace CCC
{

    public abstract class J32018
    {

        public static void Execute()
        {

            // Display instructions
            Console.WriteLine("Enter four numbers, seperated by spaces:");

            // Retrieve distances from user
            string userInput = Console.ReadLine();

            // Display distances
            Console.WriteLine("You entered: " + userInput);

            // Split distances into an array
            string[] distances = userInput.Split(' ');


            // Five different starting points
            for (int i = 1; i <= 5; i++)
            {

                // Console.WriteLine(distances[i]);
                Console.WriteLine("We are staring in city: " + i);

                Console.WriteLine("EAST: -------------------");
                Console.WriteLine("We are staring in city " + i + " and driving to city 1");
                for (int j = i; j > 1; j--)
                {
                    Console.WriteLine("Calc the dist to  " + j);
                }

                Console.WriteLine("WEST: -------------------");
                Console.WriteLine("We are staring in city " + i + " and driving to city 5");
                for (int k = i + 1; k <= 5; k++)
                {
                    Console.WriteLine("Calc the dist to city " + k);
                }

                Console.WriteLine("----------------------");
            }

        }

    }

}