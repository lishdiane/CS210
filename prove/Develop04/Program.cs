//I added an activity count that counts how many times the user did each
//activity and I added a statement at the end showing the count.

using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "0";
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;


        do
        {
            List<string> menu = new List<string>()
            {
                "1. Start Breathing Activity",  
                "2. Start Reflection Activity",
                "3. Start Listing Activity",
                "4. Quit"
            };

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Welcome to Your Mindfulness App");
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Please select an option below:");
            Console.WriteLine("");
            
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.Write("Which number would you like to choose? ");
            userChoice = Console.ReadLine();
            Console.WriteLine("-----------------------");

            if (userChoice == "1")
            {
                int time = 30;
                breathingCount += 1;

                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", time);

                Console.Clear();
                breathingActivity.StartDisplay();

                Console.WriteLine("How long in seconds do you want the Breathing Activity to run? ");
                string input = Console.ReadLine();
                time = int.Parse(input);
                breathingActivity.SetTime(time);

                breathingActivity.Run();
            }

            if (userChoice == "2")
            {
                int time = 30;
                reflectionCount += 1;

                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", time);

                Console.Clear();
                reflectionActivity.StartDisplay();

                Console.WriteLine("How long in seconds do you want the Reflection Activity to run? ");
                string input = Console.ReadLine();
                time = int.Parse(input);
                reflectionActivity.SetTime(time);

                reflectionActivity.Run();
            }

            if (userChoice == "3")
            {
                int time = 30;
                listingCount += 1;

                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", time);

                Console.WriteLine("How long in seconds do you want the Listing Activity to run? ");
                string input = Console.ReadLine();
                time = int.Parse(input);
                listingActivity.SetTime(time);

                listingActivity.Run();
            }
        }while (userChoice != "4");

        Console.WriteLine("Yay! You completed ");
        Console.WriteLine($"The Breathing Activity {breathingCount} time/s.");
        Console.WriteLine($"The Reflection Activity {reflectionCount} time/s.");
        Console.WriteLine($"The Listing Activity {listingCount} time/s.");
        Console.WriteLine("");

    }
}