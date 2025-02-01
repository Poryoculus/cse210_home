using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction example1 = new Fraction();
        Fraction example2 = new Fraction(5);
        Fraction example3 = new Fraction(3,4);
        Fraction example4 = new Fraction(1,3);


        Console.WriteLine(example1.GetFractionString());
        Console.WriteLine(example1.GetDecimalValue());
        Console.WriteLine(example2.GetFractionString());
        Console.WriteLine(example2.GetDecimalValue());
        Console.WriteLine(example3.GetFractionString());
        Console.WriteLine(example3.GetDecimalValue());
        Console.WriteLine(example4.GetFractionString());
        Console.WriteLine(example4.GetDecimalValue());
    }
}