using System.Data.Common;

public class Product
{
    
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double ProductTotal()
    {
        
        return Math.Round(_price * _quantity, 2);
    }

    public string GetDisplay()
    {
        return $"Name: {_name}, ID: #{_productId} \nPrice: ${_price}, Quantity: {_quantity}, Total: ${ProductTotal()}";
    }
}