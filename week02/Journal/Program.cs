using System;
using System.ComponentModel.DataAnnotations;


class Program
{
    static void Main(string[] args)
    {

        //variables
        Journal theJournal = new Journal();
        
        
        int userPrompt = 0;

        //Menu loop
        while (userPrompt != 5)
        {
            //Menu options
            Console.WriteLine("\nWelcome to your Personal Journal!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1.- Write");
            Console.WriteLine("2.- Display");
            Console.WriteLine("3.- Load");
            Console.WriteLine("4.- Save");
            Console.WriteLine("5.- Quit");

            //Menu selection
            Console.Write("What would you like to do?: ");
            userPrompt = int.Parse(Console.ReadLine());

            //write option

            if (userPrompt == 1)
            {
                Entry anEntry = new Entry();
                anEntry.Display();

                theJournal.AddEntry(anEntry);

            }
            //Display the journal
            if (userPrompt == 2)
            {
                theJournal.DisplayAll();
            }

            //Load the Journal text
            if (userPrompt == 3)
            {
                Console.WriteLine("Enter the filename of the journal you want to load: ");
                string fileToLoad = Console.ReadLine();
                theJournal._entries = theJournal.LoadFromFile(fileToLoad);
                
                
            }

            //Save a Journal

            if (userPrompt == 4)
            {
                Console.WriteLine("Enter the filename to save the journal: ");
                string nameToSave = Console.ReadLine();
                theJournal.SaveToJson(nameToSave);
            }

            if (!new int[] { 1, 2, 3, 4, 5 }.Contains(userPrompt))
            {
                Console.WriteLine("That's not a possible option");
            }

        }

    }
}