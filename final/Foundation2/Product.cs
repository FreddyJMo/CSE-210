public class Product 
{
    private string _name;
    private int _id, _quantity;
    private double _price;

    public Product(string name, int id, double price, int quantity) 
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName() 
    {
        return _name;
    }

    public int GetId() 
    {
        return _id;
    }

    public double GetPrice() 
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double CalculateTotalPrice() 
    {
        return _price * _quantity;
    }
}
    