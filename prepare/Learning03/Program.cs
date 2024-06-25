using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction noParameter = new Fraction();
        // Fraction oneParameter = new Fraction (6);
        // Fraction twoParameter = new Fraction(6, 7);

        // Console.WriteLine($"{noParameter} {oneParameter} {twoParameter}");
        //Fraction fraction = new Fraction(3, 4);
        // fraction.SetTop(9);
        // fraction.SetBottom(16);

        // string top = fraction.GetTop();
        // string bottom = fraction.GetBottom();

        // Console.WriteLine($"{top}/{bottom}");

        // string fractionString = fraction.GetFractionString();
        // Console.WriteLine(fractionString);

        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction (5);
        Fraction fraction2 = new Fraction(3, 4);
        Fraction fraction3 = new Fraction(1, 3);
        
        Console.WriteLine((double)fraction.GetDecimalValue());
        Console.WriteLine((string)fraction.GetFractionString());
        Console.WriteLine((double)fraction1.GetDecimalValue());
        Console.WriteLine((string)fraction1.GetFractionString());
        Console.WriteLine((double)fraction2.GetDecimalValue());
        Console.WriteLine((string)fraction2.GetFractionString());
        Console.WriteLine((double)fraction3.GetDecimalValue());
        Console.WriteLine((string)fraction3.GetFractionString());

    }
}