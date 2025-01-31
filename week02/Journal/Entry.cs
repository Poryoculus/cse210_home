using System; 

public class Entry
{
    DateTime theCurrentTime = DateTime.Now;
    PromptGenerator aPrompt = new PromptGenerator();
    public string _date;
    public string _promptText; 
    public string _entryText;

    public void Display()
    {
        string _date = theCurrentTime.ToShortDateString();
        _promptText = aPrompt.GetRandomPrompt();
        Console.WriteLine(_promptText);
        Console.Write(">");
        _entryText = Console.ReadLine();
        
    }
    
}
