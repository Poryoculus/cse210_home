using System;

public class Reflection : Activity
{
    // attributes

    private List<string> _prompt;
    private List<string> _questions;

    public Reflection(List<string> prompt, List<string> questions, int duration, string name, string description) : base(duration, name, description)
    {
        _prompt = prompt;
        _questions = questions;
    }

    
}