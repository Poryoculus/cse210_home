using System;

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
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
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
        Console.WriteLine(prompt);
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void QuestionsGenerator()
    {
        string ListOfPrompt = "ReflectionQuestions.txt";
        string[] lines = File.ReadAllLines(ListOfPrompt);

        foreach (string line in lines)
            {
                _questions.Add(line);
            } 
    }
    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
    }
}