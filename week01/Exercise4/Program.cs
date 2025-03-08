using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>(); // List to store user input
        int number;

        Console.WriteLine("Enter a series of numbers (enter 0 to stop):");

        // Keep asking for numbers until the user enters 0
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0) // Do not add 0 to the list
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Ensure there are numbers before performing calculations
        if (numbers.Count > 0)
        {
            int sum = numbers.Sum(); // Calculate sum
            double average = numbers.Average(); // Calculate average
            int max = numbers.Max(); // Find the maximum number

            Console.WriteLine($"\nSum: {sum}");
            Console.WriteLine($"Average: {average:F2}"); // Display average with 2 decimal places
            Console.WriteLine($"Maximum: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}

    
