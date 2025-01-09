using System;

class Program
{
    static void Main(string[] args)
    {
        //declare list
        List<int> numbers = new List<int>();
        int sum = 0;
        int number = -1;
        int largest = int.MinValue;
        

        Console.WriteLine("Enter the list of numbers, type 0 when is it finished");
        // while loop to start the sums
        while (number != 0)
        {
            
            number = int.Parse(Console.ReadLine());

            if (number == 0) break;
            sum += number ;
            numbers.Add(number);
            
            
        }
        foreach (int numero in numbers)
        {
            if (numero > largest)
            {
                largest = numero;
            }
        }

        float average = ((float)sum)  / numbers.Count;


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest numbers is: {largest}");
        
        
    }
}
