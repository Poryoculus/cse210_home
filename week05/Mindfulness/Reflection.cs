using System;
using System.Diagnostics.CodeAnalysis;

public class Reflection : Activity
{
    // attributes

    private List<string> _prompt = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflection(List<string> prompt, List<string> questions, int duration, string name, string description) : base(duration, name, description)
    {

        _prompt = prompt;
        _questions = questions;
    }


    public void RunActivity()
    {

        PromptGenerator();
        QuestionsGenerator();


        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(2);
        Console.Clear();

        Console.WriteLine("Consider the following prompt: ");
        Console.Write(" ---- ");
        DisplayPrompt();
        Console.Write(" ---- ");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");

        string userInput = "as";

        while (true)
        {
            userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Now ponder on each of the following questions as they relate to this experience:");
                
                break;
            }
            else
            {
                Console.WriteLine("Please leave the input empty to proceed.");
            }
        }

        //continue the acitivity

        

        Console.Clear();
        
        if (_duration < 10)
        {
            Console.WriteLine("Session duration must be greater than ten.");
            return;
        }
        

        Console.Write("You may begin in: ");
        PauseCountDown(4); 
        Console.Clear();

        int sessionQuestions = (int)Math.Ceiling(_duration / 10.0);

        while (sessionQuestions != 0)
        { 
            DisplayQuestion();
            DisplaySpinner(10);
            
            sessionQuestions -= 1;
        } 
        

        DisplayClosingMessage();
    }
    
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }

    public void PromptGenerator()
    {
        string ListOfPrompt = "ReflectionPrompts.txt";
        string[] lines = File.ReadAllLines(ListOfPrompt);

        foreach (string line in lines)
            {
                _prompt.Add(line);
            } 
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.Write(prompt);
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void QuestionsGenerator()
    {
        string ListOfQuestions = "ReflectionQuestions.txt";
        string[] lines = File.ReadAllLines(ListOfQuestions);

        foreach (string line in lines)
            {
                _questions.Add(line);
            } 
    }
    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
        Console.WriteLine(" ");
        

    }
}