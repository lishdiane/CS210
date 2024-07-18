public class OutdoorGathering : Event
{
    private string _weatherForcast;

    public OutdoorGathering(string title, string description, string date, string time, string weatherForcast) : base(title, description, date, time)
    {
        _weatherForcast = weatherForcast;
    }

    public string GetFullDetails()
    {
         return $"{GetStandardDetails()}\nWeather: {_weatherForcast}";
    }
}