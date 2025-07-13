using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotal()
    {
        double sum = 0;
        foreach (var p in products)
        {
            sum += p.GetTotalCost();
        }
        sum += customer.IsInUSA() ? 5 : 35;
        return sum;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var p in products)
        {
            label += p.Name + " (" + p.ProductId + ")\n";
        }
        return label.TrimEnd();
    }

    public string GetShippingLabel()
    {
        return customer.Name + "\n" + customer.Address.ReturnString();
    }
}
