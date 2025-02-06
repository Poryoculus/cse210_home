using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        bool isCompletelyHidden = false;
        Reference primeraref = new Reference("Juan", 3, 16);
        Scripture escritura = new Scripture(primeraref, "Porque de tal manera amó Dios al mundo, que dio a su Hijo unigénito, para que todo aquel que cree en él no se pierda, sino que tenga vida eterna");


        escritura.GetDisplayAll();

        //program

        Console.WriteLine("press enter to continue or type 'quit' to finish: ");
        string userInput = " ";
        while (userInput.ToLower() == " ")
        {
        userInput = Console.ReadLine();
        if (userInput == " ")
        {
            escritura.hideWords();
            escritura.hideWords();
            Console.WriteLine("press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
        }
        else
        {
            break;
        }
        }
    }
} 