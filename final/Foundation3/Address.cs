public class Address
{
    private string _street, _city, _state, _zipCode;

    public Address(string street, string city, string state, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetZipCode()
    {
        return _zipCode;
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}";
    }
}
