public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, string rsvpEmail) : base(title, description, date, time)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP: {_rsvpEmail}";
    }
}