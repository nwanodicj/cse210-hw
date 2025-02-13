
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Mindfulness;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start listing activity");
        Console.WriteLine("   3. Start reflecting activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select a choice from the menu ");
        string Option = Console.ReadLine();

        
        BreathingActivity BreathingActivity1= new BreathingActivity();
        if (Option == "1")
        {
            //This is my exceeding requirement, it allow the user to enter firstName and LastName
            Console.WriteLine();
            Console.Write("Enter your first name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine();

            //My exceeding requirement, this displays the user' firstName and lastName on the screen!
            Console.Write($"Hello! {FirstName} {LastName}! Your are");
            BreathingActivity1.StartBreathingSession();
            int y = 0;
            while (y <= 3)
            {
                BreathingActivity1.SetBreathIn();
                Thread.Sleep(200);
                BreathingActivity1.SetBreathOut();
                Thread.Sleep(200);
                y++;
            }
            

            Console.WriteLine(BreathingActivity1);
            //My exceeding requirement, this displays the user' firstName and lastName on the screen!
            Console.Write($"Good Job! Mr/Mrs {FirstName} {LastName}!");
            Console.WriteLine();

        }



       ListingActivity ListingActivity1= new ListingActivity();
        if (Option == "2")
        {
             //This is my exceeding requirement, it allow the user to enter firstName and LastName
            Console.WriteLine();
            Console.Write("Enter your first name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Discription: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine();

             //My exceeding requirement, this displays the user' firstName and lastName on the screen!
            Console.Write($"Hello! {FirstName} {LastName}! Your are");

            ListingActivity1.StartListingSession();
            ListingActivity1.SetCount();
            ListingActivity1.SetRandomPrompt();
            
            //My exceeding requirement, this displays the user' firstName and lastName on the screen!
            Console.Write($"Good Job! Mr/Mrs {FirstName} {LastName}!");
            Console.WriteLine();     
           
        }


    ReflectionActivity ReflectionActivity1 = new ReflectionActivity();
    if (Option == "3")
    {
        //This is my exceeding requirement, it allow the user to enter firstName and LastName
        Console.Write("Enter your first name: ");
        string FirstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string LastName = Console.ReadLine();
        Console.WriteLine();

        //My exceeding requirement, this displays the user' firstName and lastName on the screen!
        Console.Write($"Hello! {FirstName} {LastName}! Your are");

        ReflectionActivity1.StartReflectionActivity();

        Console.WriteLine("Discription: This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();

        ReflectionActivity1.SetCount();
        ReflectionActivity1.SetRandomReflectionPrompt();
        ReflectionActivity1.GetQuestion();

        //My exceeding requirement, this displays the user' firstName and lastName on the screen!
        Console.Write($"Good Job! Mr/Mrs {FirstName} {LastName}!");
        Console.WriteLine();    
    }

    if (Option == "4")
    {
        Console.WriteLine("");
    }

        Console.WriteLine();
    }
    
}