using System;

class Program
{
    static void Main(string[] args)
    {
        
        int UserPrompt = 0;
        
        //Menu interface
        while (UserPrompt != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Option: ");

            Console.WriteLine("\t1. Start Breathing Activity");
            Console.WriteLine("\t2. Start Reflection Activity");
            Console.WriteLine("\t3. Start Listing Activity");
            Console.WriteLine("\t4. Quit");

            Console.Write("Select a choice from the menu: ");
            UserPrompt = int.Parse(Console.ReadLine());

            //Activity options

            //Breathing Activity
            if (UserPrompt == 1)
            {
                Breathing myBreathing = new Breathing(30, "Breathing Activity", "This activity will help you relax and focus by guiding you through controlled breathing exercises,promoting a sense of calm and reducing stress.");
                myBreathing.DisplayWelcomeMessage();
                myBreathing.RunActivity();

            }

            //Reflection Activity
            else if (UserPrompt == 2)
            {   
                List<string> prompts = new List<string> { "What did you learn today?", "How do you feel about your progress?" };
                List<string> questions = new List<string> { "How did you overcome challenges?", "What did you learn from your mistakes?" };

                
                int duration = 30; 
                string name = "Reflection Activity";
                string description = "This activity will help you reflect on your experiences, gain insight into your personal growth, and identify areas for improvement";

                // this is chatgpt way to create an instance, i just made it to save time, because my code resolve the 
                //problem of biggest list of prompts and questions.
                Reflection reflectionActivity = new Reflection(prompts, questions, duration, name, description);
                reflectionActivity.DisplayWelcomeMessage();
                reflectionActivity.RunActivity();
            }

            //Listing Activity
            else if (UserPrompt == 3)
            {
                string name = "Listing Activity";
            }

            //Quit.
            else if (UserPrompt == 4)
            {
                break;
            }
            
            //any other prompt
            else
            {
                Console.WriteLine("That's not a valid option.");
                continue;
            }
            
        }
        Activity prueba = new Activity(20, "rodrigo", "askdalskd");
        
    }
}