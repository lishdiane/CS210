using System.Reflection.Metadata.Ecma335;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * GetLength() / 60;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} - Cycling ({GetLength()} min) \nDistance: {CalculateDistance()} miles, \nSpeed: {_speed} mph, \nPace: {CalculatePace()} min per mile");
    }
}