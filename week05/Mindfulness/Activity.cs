using System; 

public class Activity
{
    private int _duration;
    private string _name; 
    private string _description;

    public Activity(int duration, string name, string description)
    {
        _duration = duration;
        _name = name;
        _description = description;
    }
}

