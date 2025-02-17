using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract int RecordEvent();
    public abstract string GetProgress();
}
