public class Product
{
    public string Name { get; private set; }
    public string ProductId { get; private set; }
    public double PricePerUnit { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}
