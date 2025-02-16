using System;

public class Breathing : Activity
{


    //Constructor
    public Breathing(int duration, string name, string description) : base(duration, name, description)
    {
        
    }

    


    // run Activity
    public void RunActivity()
    {
        Console.Write("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(3);
        Console.Clear();
        int sessionPeriods = (int)Math.Ceiling(_duration / 10.0);
        while (sessionPeriods != 0)
        {
            
            Console.Write("Breath in");
            Console.Write("...");
            PauseCountDown(4);

            Console.Write("\nNow Breath out");
            Console.Write("...");
            PauseCountDown(6);
            Console.WriteLine(" ");
            sessionPeriods -= 1;

        }


    }
}