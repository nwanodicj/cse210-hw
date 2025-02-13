using System;
using System.Collections.Generic;
namespace Mindfulness;
public class ListingActivity:BreathingActivity
{
    protected int _Count;
    protected string _prompt;


    public int GetCount()
    {
        return _Count;
    }

    public void SetCount()
    {
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

    public string GetRandomPrompt()
    {
        return _prompt;
    }

    public void SetRandomPrompt()
    {
        Console.WriteLine("Who are people that you appreciate?");
        string UserResponse1 = Console.ReadLine();
        Thread.Sleep(500);
        Console.WriteLine();

        Console.WriteLine("What are personal strengths of yours?");
        string UserResponse2 = Console.ReadLine();
        Thread.Sleep(500);
        Console.WriteLine();

        Console.WriteLine("Who are people that you have helped this week?");
        string UserResponse3 = Console.ReadLine();
        Thread.Sleep(500);
        Console.WriteLine();

        Console.WriteLine("When have you felt the Holy Ghost this month?");
        string UserResponse4 = Console.ReadLine();
        Thread.Sleep(500);
        Console.WriteLine();

        Console.WriteLine("Who are some of your personal heroes?");
        string UserResponse5 = Console.ReadLine();
        Thread.Sleep(500);
        Console.WriteLine();

        List<string> UserEntryList = new List<string>();
        UserEntryList.Add(UserResponse1);
        UserEntryList.Add(UserResponse2);
        UserEntryList.Add(UserResponse3);
        UserEntryList.Add(UserResponse4);
        UserEntryList.Add(UserResponse5);

        Console.Write($"You responded {UserEntryList.Count} times!\n");
    }

    public void StartListingSession()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to listing activity");
        Console.WriteLine();
    }       
}
