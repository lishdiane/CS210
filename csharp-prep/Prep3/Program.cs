using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {   
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0,100);

        int guessNumber = -1;
        string response = "";

        do
        {
            int guessCount = 0;

            do
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guessNumber = int.Parse(userGuess);
                guessCount += 1;

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed correctly!");
                }
            } while (magicNumber != guessNumber);

            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.WriteLine("Do you want to play again? ");
            response = Console.ReadLine();
            
        } while (response == "yes");
    }
}