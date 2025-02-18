using System;

public class ChecklistGoal : Goal
{

    private int _AmountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _AmountCompleted = 0; 
        _target = target;
        _bonus = bonus;
    }
    

    public override string GetStringRepresentation()
    {
        if (isComplete() == false)
        { 
            return $"[] {_shortName} ({_description}) --- Currently Completed: {_AmountCompleted}/{_target} "; 
        }
        else
        {
            {return $"[X] {_shortName} ({_description}) --- Currently Completed: {_AmountCompleted}/{_target}";}
        }
    }   

    public override bool isComplete()
    {
        if (_AmountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }

    public override void RecordEvent()
    {
        _AmountCompleted++;

        if (isComplete())
        {
            Console.WriteLine($"Goal completed! Bonus {_bonus} points awarded!");
        }
    }
}