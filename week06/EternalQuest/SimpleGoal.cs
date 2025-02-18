using System;
using Newtonsoft.Json;
public class SimpleGoal : Goal
{
    [JsonProperty]
    private bool _isComplete;

    

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
        _noMorePoints = false;
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

    public override int RecordEvent()
    {
       if (_noMorePoints)
       {
        return 0;
       }
       
       _isComplete = true;
       _noMorePoints = true;
        Console.WriteLine($"Goal completed: {_shortName}");

        return _points;



    }


}