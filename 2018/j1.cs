// Display instructions
Console.WriteLine("Enter four numbers, press ENTER after each number:");

// Create a string variable and get user input from the keyboard and store it in the variable
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int num4 = Convert.ToInt32(Console.ReadLine());

// Display the complete series of numbers
Console.WriteLine("You entered " + num1 + num2 + num3 + num4);

// Check if the number is a telemarketer
if (num1 > 7 && num2 == num3 && num4 > 7)
{
    Console.WriteLine("Ignore");
}
else
{
    Console.WriteLine("Answer");
}

// Program complete
Console.WriteLine("Program complete. Press ENTER to close.");
Console.ReadKey();
