using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // My exceeding requirement
        Console.WriteLine("Welcome to goal creator");
        Console.WriteLine("Description: We will help create a goal, record event, show your goal and save it.");
        GoalManager tracker = new GoalManager();
        while (true)
        {
            Console.WriteLine("\n1. Add Goal\n2. Record Progress\n3. Show Goals\n4. Show Score\n5. Save\n6. Load\n7. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Goal Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("1. Simple\n2. Eternal\n3. Checklist");
                    Console.Write("Choose type: ");
                    int type = int.Parse(Console.ReadLine());
                    Console.Write("Enter Points: ");
                    int points = int.Parse(Console.ReadLine());
                    if (type == 1) tracker.AddGoal(new SimpleGoal(name, points));
                    else if (type == 2) tracker.AddGoal(new EternalGoal(name, points));
                    else
                    {
                        Console.Write("Enter Target Count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Enter Bonus Points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        tracker.AddGoal(new ChecklistGoal(name, points, target, bonus));
                    }
                    break;
                case 2:
                    Console.Write("Enter Goal Name: ");
                    tracker.RecordGoal(Console.ReadLine());
                    break;
                case 3:
                    tracker.ShowGoals();
                    break;
                case 4:
                    tracker.ShowScore();
                    break;
                case 5:
                    tracker.SaveGoals("goals.txt");
                    break;
                case 6:
                    tracker.LoadGoals("goals.txt");
                    break;
                case 7:
                    return;
            }
        }
    }
}
