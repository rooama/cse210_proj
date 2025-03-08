using System;

class Program
{
    static void Main(string[] args)
    {
 // Create a random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); // Random number between 1 and 100

        int guess = 0; // Initialize guess variable

        Console.WriteLine("Welcome to the Guess My Number game!");

        // Loop until the user guesses the correct number
        while (guess != magicNumber)
        {
            // Ask the user for their guess
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            // Check if the guess is too high, too low, or correct
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number.");
            }
        }
    }
}