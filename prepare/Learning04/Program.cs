using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Diane Lish", "Spelling");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Tyler Lish", "Equations", "7.3", "3-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomework());

        WritingAssignment writingAssignment = new WritingAssignment("Eva Lish", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}