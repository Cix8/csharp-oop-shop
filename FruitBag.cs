public class FruitBag : Product
{
    public int Quantity { get; private set; }
    public int MaxCapacity { get; } = 5;

    public FruitBag(string newName, string newDescription, double newPrice, uint newIva, int quantity) : base(newName, newDescription, newPrice, newIva)
    {
        if (quantity <= this.MaxCapacity)
        {
            this.Quantity = quantity;
        }
    }
}