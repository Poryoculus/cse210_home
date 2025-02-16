using System;
using System.Security.Principal;

public class Activity
{
    //activity variable 
    protected int _duration;
    private string _name; 
    private string _description;

    //Constructor
    public Activity(int duration, string name, string description)
    {
        _duration = duration;
        _name = name;
        _description = description;
    }

    public void DisplaySpinner(int time)
    {
    
       char[] spinnerChars = { '⏳', '⌛' };
       int timeElapsed = 0;
       int index = 0;
       int SpinnerDuration = time;
       while (timeElapsed < SpinnerDuration * 1000)
        {
            Console.Write($"{spinnerChars[index]}"); // Print spinner character
            Thread.Sleep(500); // Pause for smooth animation
            Console.Write("\b \b"); // Erase previous character

            index = (index + 1) % spinnerChars.Length; // Cycle through spinner chars
            timeElapsed += 200;
       }
    }


    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        DisplaySpinner(1);
        Console.WriteLine($"This activity will help you {_description}");

        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = Console.Read();
    }

    public void DisplayClosingMessage()
    {
        Console.WriteLine("Well Done!!");
        DisplaySpinner(2);
        Console.WriteLine($"You completed another 30 seconds of the {_name}");
    }

    public void PauseCountDown(int seconds)
    {
        
        int downSeconds = seconds;
        for (int i = downSeconds; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
    }
}

