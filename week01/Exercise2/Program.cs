using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade porcentage? ");
        int grade = int.Parse(Console.ReadLine());


        //giving a letter to the score 
        string letter;

        if (grade >= 90)
        {
            letter = "A";

        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        
        else if (grade >= 70)
        {
            letter = "C";
        }
        
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.Write($"You grade is a {letter}");

        //consider if the grade is + or -

        if (letter != "A" && letter != "F")
        {
            if (grade % 10 <= 6)

            {
                Console.WriteLine("-");
            }
            
            else 
            
            {
                Console.WriteLine("+");
            }
        }
        else {
            Console.WriteLine(" ");
        }
        
        //print if the student passed or not
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations!! you passed.");
        }
        else
        {
            Console.WriteLine("You failed the class, you have to try harder the next time");

        }
    }
}