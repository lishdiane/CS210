using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> activities = new List<Activity>();

        Running running = new Running("November 04, 2024", 30, 2);
        activities.Add(running);

        Cycling cycling = new Cycling("September 08, 2024", 120, 15);
        activities.Add(cycling);

        Swimming swimming = new Swimming("August 30, 2024", 60, 10);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine();
        }

    }
}