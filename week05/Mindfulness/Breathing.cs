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

        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(3);
        Console.Clear();

        if (_duration < 10 )
        {
            Console.WriteLine("Session duration must be greater than ten.");
            return;
        }
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