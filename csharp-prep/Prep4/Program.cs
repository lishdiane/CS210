using System;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = 1;
        float total = 0;
        int largest = 0;
        int smallest = 99999999;

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }

                if (number < smallest && number > 0)
                {
                    smallest = number;
                }

                total += number;
            }
        
        float average = total / numbers.Count;
        numbers.Sort();

        Console.WriteLine($"The Sum is: {total}");
        Console.WriteLine($"The average is : {average}");
        Console.WriteLine($"The Largest number is : {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}