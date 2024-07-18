public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;   
    }

    public override double CalculateSpeed()
    {
        return _distance / GetLength() * 60;
    }

    public override double CalculatePace()
    {
        return GetLength() / _distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} - Running ({GetLength()} min) \nDistance: {_distance} miles, \nSpeed: {CalculateSpeed()} mph, \nPace: {CalculatePace()} min per mile");
    }

}