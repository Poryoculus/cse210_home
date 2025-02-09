public class Address
{
    private string _steetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {

    }

    public string GetAddress()
    {
        return "Address";
    }

    public bool livesInUSA()
    {
        if (_country == "usa")
        {
            return true;
        }
            
        else
        {
            return false;
        }
    }
}