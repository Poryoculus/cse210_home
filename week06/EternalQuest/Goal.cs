using System;
using Newtonsoft.Json;

public abstract class Goal
{
    [JsonProperty]
    protected string _shortName;
    [JsonProperty]
    protected string _description;

    [JsonProperty]
    protected int _points; // i change it to an int because how i'll save the data i don't need it to be a str (JSON file)
    [JsonProperty]
    protected bool _noMorePoints;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool isComplete();
    public virtual string GetDetailsString()
    {
        return "string";
    }
    public abstract string GetStringRepresentation();

    public virtual string GetName()
    {
        return _shortName;
    }

    


}