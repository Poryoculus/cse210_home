using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        JsonLector lector = new JsonLector();
        List<Scripture> ListOfScriptures = lector.LoadScriptures("scriptures.json");
        Random rand = new Random();
        int index = rand.Next(ListOfScriptures.Count);

        
        Scripture escritura = ListOfScriptures[index];
        bool completelyHidden = escritura.isCompletelyHidden();

        escritura.GetDisplayAll();

        //program
        Console.WriteLine(" ");
        Console.WriteLine("press enter to continue or type 'quit' to finish: ");
        string userInput = Console.ReadLine();
        while (completelyHidden != true)
        {
        if (userInput == "")
        {
            escritura.hideWords();
            
            escritura.GetDisplayAll();
        }

        
        if (escritura.isCompletelyHidden())
            {
                break;
            }

        Console.WriteLine("\npress enter to continue or type 'quit' to finish: ");
        userInput = Console.ReadLine();
        }
    }
} 