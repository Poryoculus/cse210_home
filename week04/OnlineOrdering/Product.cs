public class Product
{
    private string _name;
    public int _productID;
    private double _productPrice;
    private int _productQuantity;

    public Product(string name, int productID, double price, int productQuantity)
    {
        _name = name;
        _productID = productID;
        _productPrice = price;
        _productQuantity = productQuantity;
    }

    public double GetTotalCost( )
    {
        double  totalCost = _productPrice * _productQuantity;
        return totalCost;
    }
    
}