using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 6);
        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("pink", 6, 3);
        Console.WriteLine($"Color: {rectangle.GetColor()}");
        Console.WriteLine($"Area: {rectangle.GetArea()}");

        Circle circle = new Circle("yellow", 6);
        Console.WriteLine($"Color: {circle.GetColor()}");
        Console.WriteLine($"Area: {circle.GetArea()}");

    }
}