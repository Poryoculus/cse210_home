public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string Street, string City, string State, string Country)
    {
        _streetAddress = Street;
        _city = City;
        _state = State;
        _country = Country;
    }

    public string GetAddress()
    {
        return "Address";
    }

    public bool livesInUSA()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
            
        else
        {
            return false;
        }
    }
}