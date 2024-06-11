using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResults(PromptUserName(),SquareNumber(PromptUserNumber()));

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;

        return numberSquared;
    }

    static void DisplayResults(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }
}