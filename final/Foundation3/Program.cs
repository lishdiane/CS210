using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Be Successful", "John Smith presents the best way to be successful.", "August 30, 2024", " 9:00a - 1:00p", "John Smith", 200);
        Address address1 = new Address("1234 Success st.", "Pocatello", "ID", "83291");
        lecture.SetAddress(address1);

        Reception reception = new Reception("Lish Reception", "A wedding reception for Kay and Jared Lish.", "Sepetember 4, 2024", "5:00p - 9:00p", "rspv@events.com");
        Address address2 = new Address("444 Meadow rd.", "Stanley", "ID", "86645");
        reception.SetAddress(address2);

        OutdoorGathering outdoorGathering = new OutdoorGathering("Smith Wedding", "John Smith and Karen Davis Wedding.", "September 28, 2024", "1:00p", "78 degrees, Partly Cloudy, 5mph winds.");
        Address address3 = new Address("4321 Rainbow rd.", "American Falls", "ID", "87632");
        outdoorGathering.SetAddress(address3);

        Console.Clear();

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDetails());
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDetails());


    }
}