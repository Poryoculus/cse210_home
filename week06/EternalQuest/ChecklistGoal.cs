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
        _noMorePoints = false;
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

    public override bool isComplete()
    {
        return _amountCompleted >= _target;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (isComplete())
        {
            Console.WriteLine("This goal is already complete.");
            if (_noMorePoints)
            {
                return 0;
            }
            return _points + bonus;
            
        }
        
        
        else 
        {
            return _points;
        }
    }
}