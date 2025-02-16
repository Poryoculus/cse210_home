using System;
using System.Reflection.Metadata;

public class Listing : Activity
{
    private List<string> _prompt;
    private int _count;

    public Listing(List<string> prompt, int count, List<string> responses, int duration, string name, string description) : base(duration, name, description)
    {
        
        _prompt = prompt;
        _count = count;
        
    }

    public void RunActivity()
    {
        
        
        PromptGenerator();
        string _prompt = GetRandomPrompt();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(2);
        
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.Write(" ---- ");
        
        Console.Write(_prompt);
        Console.Write(" ---- ");

        List<string> userResponses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(3000);
        
        DateTime currentTime = DateTime.Now;
        while (startTime < futureTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                userResponses.Add(response);
            }
            _count += 1;
            
        }

        


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

    
    
}   

