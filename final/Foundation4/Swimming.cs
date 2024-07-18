public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int length, double laps) : base (date, length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 100;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / GetLength() * 60;
    }

    public override void GetSummary()
    {
         Console.WriteLine($"{GetDate()} - Swimming ({GetLength()} min) \nDistance: {CalculateDistance()} miles, \nSpeed: {CalculateSpeed()} mph, \nPace: {CalculatePace()} min per mile");
    }
}