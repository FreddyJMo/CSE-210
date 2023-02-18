using System;
using System.Collections.Generic;
using System.Text;
class Order
{
    private Customer _customer;
    private List<Product> _products;
    

    public Order(Customer customer)
    {
        this._customer = customer;
        this._products = new List<Product>();
    }


    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice += product.CalculateTotalPrice();
        }

        totalPrice += _customer.IsInUSA() ? 5 : 35;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();

        packingLabel.AppendLine("Packing Label:");
        packingLabel.AppendLine("=======================================");

        foreach (Product product in _products)
        {
            packingLabel.AppendLine(product.GetName() + ", SKU " + product.GetId() + " - $" + product.GetPrice() + " x " + product.GetQuantity());
        }

        return packingLabel.ToString();
    }

    public string GetShippingLabel()
{
    StringBuilder shippingLabel = new StringBuilder();

    shippingLabel.AppendLine("Shipping Label:");
    shippingLabel.AppendLine("=======================================");
    shippingLabel.AppendLine(_customer.GetName());
    shippingLabel.Append(_customer.GetAddress().ToString());

    return shippingLabel.ToString();
}

}

