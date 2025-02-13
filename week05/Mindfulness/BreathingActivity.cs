using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity
{
    protected string _BreathIn;
    protected string _BreathOut;


    public string GetBreathIn()
    {
        return $"{_BreathIn}";
    }

    public void SetBreathIn()
    {
        List<string> BreathIn = new List<string>();
        BreathIn.Add("Breath In...");
    
        foreach (string breath in BreathIn)
        {
            Console.Write($"{breath}\n");
            int j = 0;
            for (j = 5; j > 0; j--)
            {
                Console.Write($"{j}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public string GetBreathOUt()
    {
        return $"{_BreathOut}";
    }

    public void SetBreathOut()
    {
        List<string> BreathOut = new List<string>();
        BreathOut.Add("Breath Out...");
            foreach (string breath in BreathOut)
            {
                Console.Write($"{breath}\n");
                int j = 0;
                for (j = 5; j > 0; j--)
                {
                    Console.Write($"{j}");
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
            }
    }
    
    public void StartBreathingSession()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to breathing activity");
        Console.WriteLine();
    
        Console.WriteLine("Discription: This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?: ");
        string Seconds = Console.ReadLine();
        int UserSessionTime = int.Parse(Seconds);
        Console.WriteLine("Get ready...");
        int i = 0;
        if (i <= UserSessionTime || i >= UserSessionTime)
        {
            List<string> AnimationStrings = new List<string>();
            AnimationStrings.Add("|");
            AnimationStrings.Add("/");
            AnimationStrings.Add("-");
            AnimationStrings.Add("\\");
            AnimationStrings.Add("|");
            AnimationStrings.Add("/");
            AnimationStrings.Add("-");
            AnimationStrings.Add("\\");
            
            DateTime StartTime = DateTime.Now;
            DateTime EndTime = StartTime.AddSeconds(5);
            int a = 0;
            while (DateTime.Now < EndTime)
            {
                string s = AnimationStrings[a];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                a++;
                if (a >= AnimationStrings.Count)
                {
                    a = 0;
                }
            }
        }
    }
}