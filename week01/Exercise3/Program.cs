using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        do 
        {
            
            Console.Write("What is the magic number?: ");

            int magicnumber = int.Parse(Console.ReadLine());
            int guess = 0;
            int attempts = 0;
            while (guess != magicnumber)
            {
                Console.Write("What is you magic number?: ");
                guess = int.Parse(Console.ReadLine());
                attempts += 1;
                if (guess < magicnumber)
                {
                    Console.WriteLine("Higher");

                }
                else if (guess > magicnumber)
                {
                    Console.WriteLine("Lower");
                }
                
            }
            Console.WriteLine($"Congratulations! You guessed with {attempts} attempts");
            Console.WriteLine("Do you want to continue? (yes/no)");
            response = Console.ReadLine();

        } while ( response == "yes");
    }
}