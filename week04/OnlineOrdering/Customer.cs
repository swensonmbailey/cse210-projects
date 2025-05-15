public class Customer
{
    private string _name;
    private Address _address;
    
    public Customer(string name, string street, string city, string province, string country, string zip)
    {
        _name = name;
        _address = new Address(street, city, province, country, zip);
    }

    public string GetName(){
        return _name;
    }

    public bool IsInUsa(){
        return _address.IsInUsa();
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}