public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public string GetName()
    {
        return _name;
    }

    public bool InUsa()
    {
        return _address.InUsa();
    }
}