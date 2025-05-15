using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order order1 = new Order();
        Order order2 = new Order();
     

        order1.SetCustomer("Karla Bailey", "408 S 40th", "Fort Smith", "AR", "USA", "72903");
        order1.AddProduct("Wet wipes", "1234567", 4.45, 3);
        order1.AddProduct("Size 5 Diapers", "7643215", 19.42, 3);
        order1.AddProduct("Chocolate Milk", "3214567", 4.00, 1);

        order2.SetCustomer("Swenson Bailey", "Jiron Aguila", "Lima", "Lima", "Peru", "11111");
        order2.AddProduct("Harry Potter 4 Hardcover", "1234567", 20.00, 1);
        order2.AddProduct("Samsung Phone Case", "2317645", 10.00, 1);
        order2.AddProduct("Snack bags", "2317654", 1, 5);

        orders.Add(order1);
        orders.Add(order2);
      


        foreach (var order in orders)
        {
            order.DisplayPackingLabel();
            order.DisplayShippingLabel();
            order.DisplayTotalPrice();
        }
    }
}