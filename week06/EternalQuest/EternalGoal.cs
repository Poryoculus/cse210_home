using System;
using System.Drawing;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override string GetStringRepresentation()
    {
        return $"[] {_shortName} ({_description})";
    }

    public override bool isComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {_points} points for {_shortName}!");
    }
}