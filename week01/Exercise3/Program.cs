using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);
        
        Console.WriteLine($"What is the magic number? {randomNumber}");// Magic Number

        Console.Write("What is your guess? ");// User input guess
        int userGuessed = int.Parse(Console.ReadLine());// parse the user input to integer

        if (userGuessed == randomNumber)// Conditions for the magic number
        {
            Console.WriteLine("Congratulations! You guessed it.");// Output for the magic number
        }

        else if (userGuessed > randomNumber)// Conditions for the magic number
        {
            Console.WriteLine("High! Try again.");
        }
        else if (userGuessed < randomNumber)// Conditions for the magic number
        {
            Console.WriteLine("low! Try again.");// Output for the magic number
        }

        while (userGuessed != randomNumber)
        {
            Console.Write("What is your guess? ");// User input guess
            userGuessed = int.Parse(Console.ReadLine());// parse the user input to integer

            if (userGuessed == randomNumber)// Conditions for the magic number
            {
                Console.WriteLine("Congratulations! You guessed it.");// Output for the magic number
            }
            else if (userGuessed > randomNumber)// Conditions for the magic number
            {
                Console.WriteLine("High! Try again.");
            }
            else if (userGuessed < randomNumber)// Conditions for the magic number
            {
                Console.WriteLine("low! Try again.");// Output for the magic number
            }
        }
    }
}