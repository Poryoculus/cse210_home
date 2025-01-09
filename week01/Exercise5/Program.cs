using System;

class Program
{
    static void Main(string[] args)
    {
    //call all the functions
    DisplayWelcome();
    string name = PromptUserName();
    int number = PromptUserNumber();
    int square = SquareNumber(number);
    DisplayResult(name, square);
    } 
    //dipsplay welcome to the user 
    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //prompt for a name
    static string PromptUserName ()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

        //Promp for user's favorite number 
    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber (int number)
    {
        return number * number;
    }

    static void DisplayResult (string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");
    }

        
    
        
}   

