using System.Globalization;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _totalPrice;

    public Order()
    {

    }

    public void SetCustomer(string name, string street, string city, string province, string country, string zip)
    {
        _customer = new Customer(name, street, city, province, country, zip);
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _products.Add(product);

        TotalPrice();
    }

    private void TotalPrice()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.TotalPrice();
        }

        if (_customer.IsInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        _totalPrice = Math.Round(total, 2);
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine($"Packing Label:");
        Console.WriteLine($"Number of items: {_products.Count}");
        foreach (var product in _products)
        {
            product.DisplayProduct();
        }
        Console.WriteLine("");
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Shipping Label:");
        Console.WriteLine($"Customer:");
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress()}");
    }

    public void DisplayTotalPrice()
    {
        Console.WriteLine($"Order's Total: ${_totalPrice.ToString("F2")}\n\n");
    }
}