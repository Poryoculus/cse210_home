using System;
using System.Security.Principal;

public class Activity
{
    //activity variable 
    public int _duration;
    protected string _name; 
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
    
       char[] spinnerChars = {'⏳', '⌛'};
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
            Console.Write("\r");
       }
    }


    public void DisplayWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"\nThis activity will help you {_description}");

        Console.WriteLine("\nHow long, in seconds, would you like for your session?(it must be greater than 10 seconds): ");
        _duration = Console.Read();
    }

    public void DisplayClosingMessage()
    {
        Console.WriteLine("Well Done!!");
        DisplaySpinner(2);
        Console.WriteLine($"You completed another {_duration} seconds of the {_name}");
        Thread.Sleep(5000);
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

