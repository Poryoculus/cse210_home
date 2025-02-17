using System;
using System.Reflection.Metadata;
using System.Diagnostics;

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
        string selectedPrompt = GetRandomPrompt();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(2);
        
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" ---- {selectedPrompt} ---- ");

        List<string> userResponses = new List<string>();
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);

        Stopwatch stopwatch = new Stopwatch();
        Thread.Sleep(3000);
        
        Console.Write("You will start in: ");
        PauseCountDown(5);


        stopwatch.Start(); // Start the timer
        Console.WriteLine("\n\n");
        while (stopwatch.Elapsed.Seconds < _duration)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                userResponses.Add(response);
                _count += 1;

            }

        }
        stopwatch.Stop(); 

        SaveLog(selectedPrompt, userResponses);
        Console.WriteLine($"\n You listed {_count} items");

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

    private void SaveLog(string prompt, List<string> responses)
    {
        string logFilePath = "ListingLog.txt";
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"[{DateTime.Now}]: Prompt: {prompt}");
            foreach (string response in responses)
            {
                writer.WriteLine($"- {response}");
            }
            writer.WriteLine("-----\n");
        }
    }
    
}   

