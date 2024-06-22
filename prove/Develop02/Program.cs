
// I added an option that asks if the user wants a prompt or not. If the user says no, a prompt
// is not given or saved along with entry.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;
using System.IO;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        string menuOption = "";

        Journal journal = new Journal();
        

        do
        {   
            Console.WriteLine();
            Console.WriteLine("My Journal");
            Console.WriteLine("----------------------------");

            List<string> options = new List<string>();
            options = 
            [
                "1. Write a New Entry", 
                "2. Display Journal", 
                "3. Save Journal", 
                "4. Load Journal", 
                "5. Close"
            ];

            foreach(string option in options)
            {   
                Console.WriteLine(option);
            }

            Console.WriteLine();
            Console.Write("Please select an option: ");

            menuOption = Console.ReadLine();

            Console.WriteLine("----------------------------");
            Console.WriteLine();
            

            if (menuOption == "1")
            {
                

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                PromptGenerator prompt = new PromptGenerator();
                string randomPrompt = prompt.GetRandomPrompt();

                Console.WriteLine("Would you like a prompt suggestion? yes/no ");
                string response = Console.ReadLine();

                Console.WriteLine();

                if (response == "yes")
                {
                    Console.WriteLine(randomPrompt);   
                }

                else if (response == "no")
                {
                    randomPrompt = "";
                }
               
                Console.Write(">");
                string userEntry = Console.ReadLine(); 
                Console.WriteLine();
               
                Entry entry = new Entry
                {
                    _date = dateText,
                    _promptText = randomPrompt,
                    _entryText = userEntry,
                };

                journal.AddEntry(entry);
            }

            else if (menuOption == "2")
            {
              journal.DisplayAll();
            }

            else if (menuOption == "3")
            {
                Console.Write("What would you like to save your file as? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }

            else if (menuOption == "4")
            {
                Console.WriteLine("What file would you like to open?");
                string openFileName = Console.ReadLine();
                Console.WriteLine();
                journal.LoadFromFile(openFileName);
            }

        } while (menuOption != "5"); 
    }
}
