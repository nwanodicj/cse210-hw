using System;
using System.Collections.Generic;
using System.IO;


class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoal(string name)
    {
        foreach (var goal in goals)
        {
            if (goal.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                score += goal.RecordEvent();
                Console.WriteLine("Progress recorded!");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void ShowGoals()
    {
        Console.WriteLine("Your Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetProgress());
        }
    }

    public void ShowScore()
    {
        Console.WriteLine("Total Score: " + score);
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetType().Name + "," + goal.Name + "," + goal.Points);
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts[0] == "SimpleGoal") goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2])));
                    else if (parts[0] == "EternalGoal") goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
                    else if (parts[0] == "ChecklistGoal") goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), 5, 500));
                }
            }
        }
    }
}