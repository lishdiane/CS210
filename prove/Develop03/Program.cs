// I added a difficulty choice that determines the number of words hidden at a time.

using System;
using System.Security.Cryptography;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {   
        bool complete = false;
        string enter = "";

        Console.Clear();

        Console.WriteLine("What difficulty would you like? ");
        Console.WriteLine("");
        Console.WriteLine("1. Easy: 2 words are hidden at a time.");
        Console.WriteLine("2. Medium: 3 words are hidden at a time.");
        Console.WriteLine("3. Hard: 4 words are hidden at a time.");
        Console.WriteLine("");
        Console.Write("Please enter a number: ");

        string difficulty = Console.ReadLine();
        int numberToHide = int.Parse(difficulty);

        if (difficulty == "1")
        {
            numberToHide = 2;
        }

        else if (difficulty == "2")
        {
            numberToHide = 3;
        }

        else if (difficulty == "3")
        {
            numberToHide = 4;
        }

        Console.Clear();

        Reference reference = new Reference("Mosiah", 2, 17);
        Scripture scripture = new Scripture(reference, "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellowbeings ye are only in the service of your God." );

        string referencetxt = reference.GetDisplayText();
        string scripturetxt = scripture.GetDisplayText();
        Console.Write(referencetxt);
        Console.WriteLine(scripturetxt);

        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
       
        do 
        {
            if (enter == "")
            {
                enter = Console.ReadLine();

                scripture.HideRandomWords(numberToHide);

                Console.Clear();
                string withBlanks = scripture.GetDisplayText();

                Console.Write(referencetxt);
                Console.WriteLine(withBlanks);
                
                Console.WriteLine("");
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

                complete = scripture.IsCompletelyHidden();
            }

            else if (enter == "quit")
            {
                complete = true;
            }

        }while (complete == false);  
    }
}