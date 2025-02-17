using System;
using System.Collections.Generic;
using System.IO;

class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            _timesCompleted++;
            if (_timesCompleted >= _targetCount)
            {
                IsCompleted = true;
                return Points + _bonusPoints;
            }
            return Points;
        }
        return 0;
    }

    public override string GetProgress()
    {
        return (IsCompleted ? "[X] " : "[ ] ") + Name + $" (Completed {_timesCompleted}/{_targetCount})";
    }
}

