using System;
using System.Collections.Generic;
using System.IO;

class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetProgress()
    {
        return "[∞] " + Name;
    }
}