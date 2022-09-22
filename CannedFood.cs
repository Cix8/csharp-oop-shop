public class CannedFood : Product
{
    public int Quantity { get; private set; }
    public int MaxCapacity { get; } = 300;

    public CannedFood(string newName, string newDescription, double newPrice, uint newIva, int quantity) : base(newName, newDescription, newPrice, newIva)
    {
        if(quantity <= 300)
        {
            this.Quantity = quantity;
        }
    }
}