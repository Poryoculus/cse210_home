using System;

public class Listing : Activity
{
    private List<string> _prompt;
    private int _count;

    public Listing(List<string> prompt, int count, int duration, string name, string description) : base(duration, name, description)
    {
        
        _prompt = prompt;
        _count = count;
    }

    public void RunActivity()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        
    }
}   