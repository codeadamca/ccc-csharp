using System;

namespace CCC
{

    public abstract class J32022
    {

        public static void Execute()
        {

            // Display instructions
            Console.WriteLine("Enter harp tunning iunstructions:");

            // Retrieve distances from user
            string instructions = Console.ReadLine();

            
            // Display distances
            Console.WriteLine("You entered: " + instructions);

            string notes = "";
            string dir = "";
            string turns = "";

            foreach (char c in instructions)
            {

                if( Char.IsLetter(c) && turns.Length > 0)
                {
                    Console.WriteLine(notes + " " + dir + " " + turns);

                    notes = "";
                    dir = "";
                    turns = "";
                }

                if (c == '+')
                {
                    dir = "tighten";
                }
                else if(c == '-')
                {
                    dir = "loosen";
                }
                else if(Char.IsNumber(c))
                {
                    turns += c.ToString();
                }
                else
                {
                    notes += c.ToString();
                }

            }

            Console.WriteLine(notes + " " + dir + " " + turns);

            /*
            // Split distances into an array
            string[] distances = distancesInput.Split(' ');


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
            */

        }

    }

}