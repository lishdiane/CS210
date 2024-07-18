public class Event
{
    private string _eventTitle;
    private string  _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public string GetStandardDetails()
    {
        return $"{_eventTitle} -- {_description}\nDate: {_date}, Time: {_time}\n{GetAddress()}";
    }

    public string GetShortDetails()
    {
        return $"{GetType().Name}\n{GetTitle()}\n{GetDate}";
    }
    
    public void SetAddress(Address address)
    {
        _address = address;
    }

    public string GetAddress()
    {
        return _address.GetAddressDetails();
    }


    public string GetTitle()
    {
        return _eventTitle;
    }

    public string GetDate()
    {
        return _date;
    }
}
