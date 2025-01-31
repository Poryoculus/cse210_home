using System;
using System.IO;
public class PromptGenerator
{
    public List<string> _prompt = new List<string>( );
    

    public PromptGenerator()
    {
            string ListOfPrompt = "Prompts.txt";
    string[] lines = File.ReadAllLines(ListOfPrompt);

    foreach (string line in lines)
    {
        _prompt.Add(line);
    } 
    
    }
    


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
    
}