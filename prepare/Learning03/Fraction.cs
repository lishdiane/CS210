using System.Dynamic;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetTop()
    {   
        string top = _top.ToString();
        return top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public string GetBottom()
    {
        string bottom = _bottom.ToString();
        return bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string top = _top.ToString();
        string bottom = _bottom.ToString();
    
        return $"{top}/{bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }
}