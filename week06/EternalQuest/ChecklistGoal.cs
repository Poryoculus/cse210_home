using System;
using Newtonsoft.Json;
public class ChecklistGoal : Goal
{
    [JsonProperty] 
    private int _amountCompleted;
    [JsonProperty] 
    private int _target;
    [JsonProperty]
    private int _bonus;

    public int bonus => _bonus;
    
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0; 
        _target = target;
        _bonus = bonus;
    }
    

    public override string GetStringRepresentation()
    {
        if (isComplete() == false)
        { 
            return $"[] {_shortName} ({_description}) --- Currently Completed: {_amountCompleted}/{_target} "; 
        }
        else
        {
            {return $"[X] {_shortName} ({_description}) --- Currently Completed: {_amountCompleted}/{_target}";}
        }
    }   

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
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
        if (IsComplete())
        {
            Console.WriteLine("This goal is already complete.");
            return;
        }

        _amountCompleted++;

        if (IsComplete())
        {
            Console.WriteLine($"Goal completed! Bonus {_bonus} points awarded!");
            AddPoints(_bonus + _points);  // Adds both base points and bonus.
        }
        else
        {
            Console.WriteLine($"You won {_points} points!");
            AddPoints(_points);
        }
    }
}