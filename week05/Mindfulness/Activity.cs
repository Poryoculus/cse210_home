using System; 

public class Activity
{
    //activity variable 
    private int _duration;
    private string _name; 
    private string _description;

    //Constructor
    public Activity(int duration, string name, string description)
    {
        _duration = duration;
        _name = name;
        _description = description;
    }

    public void DisplaySpinner()
    {
        Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-");
    }

    public void DisplayWelcomeMessage()
    {

    }

    public void DisplayClosingMessage()
    {

    }

    public void PauseCountDown()
    {

    }
}

