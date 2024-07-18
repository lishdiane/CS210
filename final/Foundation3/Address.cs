public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipcode;

    public Address(string street, string city, string state, string zipcode)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
    }

    public string GetAddressDetails()
    {
        return $"{_streetAddress}\n{_city}, {_state} {_zipcode}";
    }
}