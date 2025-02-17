using System;
using System.Collections.Generic;


// Running class
class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / GetMinutes()) * 60;
    public override double GetPace() => GetMinutes() / distance;
}
