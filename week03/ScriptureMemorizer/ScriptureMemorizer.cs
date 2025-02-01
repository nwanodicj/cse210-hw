using System;
using System.Collections.Generic;

class ScriptureMemorizer
{
    static void Main(string[] args)
    {
        // I added Exceeding requirement to get the user's first and last name

        // User should first enter his or her firstName and LastName, before starting scripture memorizer program
        Console.WriteLine("");
        Console.WriteLine("Please entered your firstName and lastName, before starting scripture memorizer program");

        Console.Write("Enter Your FirstName: ");
        string FirstName = Console.ReadLine();
        Console.Write("Enter Your LastName: ");
        string LastName = Console.ReadLine();

        Console.WriteLine("Now you have entered your firstName and lastName, you can start the sripture memorizer program");
        Console.WriteLine("");

        string scripture = "Proverb 3:5-6 ¶ Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.";
        List<string> words = new List<string>(scripture.Split(' '));
        Random random = new Random();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(string.Join(" ", words));
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            //I added Exceeding requirement to appreciate and display the user first and last name on the screen
            {
                Console.WriteLine($"Good job! {FirstName} {LastName}, Bye.");
                Console.WriteLine("");
                break;
            }

            int index = random.Next(words.Count);
            words[index] = new string('_', words[index].Length);

            //if (input.ToLower() != "quit")
            ////Exceeding requirement
            //{
            //    Console.WriteLine("Good job! Bye.");
            //    break;
            //}
            
        }

    }
}