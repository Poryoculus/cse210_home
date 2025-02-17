using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red" , 4);
        Rectangle myRectangle = new Rectangle("Red", 5.0, 3.0);
        Circle myCircle = new Circle("Blue", 4.5);

        

        List<Shape> myList = new List<Shape>();

        myList.Add(square);
        myList.Add(myCircle);
        myList.Add(myRectangle);

        foreach (Shape form in myList)
        {
            Console.WriteLine($"Your Area: {form.GetArea()} and it's color is {form.GetColor()}");
        }
    }
}