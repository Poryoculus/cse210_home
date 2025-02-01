using System; 

public class Entry
{
    DateTime theCurrentTime = DateTime.Now;
    PromptGenerator aPrompt = new PromptGenerator();
    public string _date { get; set; }
    public string _promptText { get; set;}
    public string _entryText { get; set;}

    public void Display()
    {
        _date = theCurrentTime.ToShortDateString();
        _promptText = aPrompt.GetRandomPrompt();
        Console.WriteLine(_promptText);
        Console.Write(">");
        _entryText = Console.ReadLine();
    }
    
}
