public class Product
{
    private string _name;
    private string _productid;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _productid = id;
        _price = price;
        _quantity = quantity;
    }

    public double TotalPrice()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _productid;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{_name} Id: {_productid} Quantiity: {_quantity} @ ${_price}");
    }


}