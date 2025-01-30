using System;

public class PromptGenerator
{
    public List<string> _prompt = new List<string>();

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        Console.WriteLine(_prompt[index]);
        return _prompt[index];
    }
    
}