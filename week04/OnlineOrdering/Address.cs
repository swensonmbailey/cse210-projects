public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;
    private string _zip;

    public Address(string street, string city, string province, string country, string zip){
        _street = street;
        _city = city;
        _province = province;
        _country = country;
        _zip = zip;
    }


    public bool IsInUsa()
    {
        if(_country == "USA")
        {
            return true;
        }else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street} {_city}, {_province}\n{_country} {_zip}";
    }
}