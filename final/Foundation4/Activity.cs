public class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return CalculateDistance() / _length * 60;
    }

    public virtual double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

    public virtual void GetSummary()
    {

    }

    public double GetLength()
    {
        return _length;
    }

    public string GetDate()
    {
        return _date;
    }
}