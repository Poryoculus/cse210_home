using System.Numerics;

public class Order
{
    public List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();

    }

    public double CalculateTotalCost()
    {
        double Total = 0;
        foreach (Product item in _products)
        {
            Total += item.GetTotalCost();
        }
        if (_customer._address.livesInUSA() == true)
        {
            Total += 5;
        }
        else 
        {
            Total += 35;
        }
        return Total;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine($"Customer: {_customer._name}");
        foreach (Product item in _products)
        {
            Console.WriteLine($"Product ID: {item._productID}");
            
        }
    }    
    public void GetShippingLabel()
    {
        Console.WriteLine($"From: (Company name)");
        Console.WriteLine($"To: {_customer._name}\n Address: {_customer._address}");

    }
}