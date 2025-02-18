using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public override string GetStringRepresentation()
    {
        if (_isComplete == false)
        {return $"[] {_shortName} ({_description})";}
        else
        {
            return $"[X] {_shortName} ({_description})";
        }
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
       _isComplete = true;
        Console.WriteLine($"Goal completed: {_shortName}");

    }

}