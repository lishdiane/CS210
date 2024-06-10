using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage did you receive? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        int lastDigit = number % 10;

        string letter = "";
        string suffix = "";


        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            suffix = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            suffix = "-";
        }

        Console.WriteLine($"Your grade is: {letter}{suffix}");

        if (number >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else 
        {
            Console.WriteLine("You did not pass the class.");
        }

    }
}