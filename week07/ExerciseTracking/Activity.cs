using System;
using System.Diagnostics;

public abstract class Activity
{
    protected int _duration;
    protected string _date;

    public Activity (string date, int duration)
    {
        _date = date; 
        _duration = duration;

    }
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_duration} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}