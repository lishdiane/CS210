using System.Numerics;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProductToList(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.ProductTotal();
        }

        if (_customer.InUsa() == true)
        {
            return Math.Round(total + 5, 2);
        }
        else
        {
            return Math.Round(total + 35, 2);
        }
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetDisplay());
            Console.WriteLine();
        }
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }


}