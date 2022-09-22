public class CannedFood : Product, ILimitedCapacity
{
    public float MaxCapacity { get; } = 300;
    public int Quantity { get; private set; }
    public DateOnly ExpirationDate { get; private set; }
    public DateOnly ProductionDate { get; private set; }

    public CannedFood(string newName, string newDescription, double newPrice, uint newIva, int quantity, string expirationDate, string productionDate) : base(newName, newDescription, newPrice, newIva)
    {
        if (quantity <= 300)
        {
            this.Quantity = quantity;
        } else
        {
            throw new Exception("La capacità inserita supera la capacità massima!");
        }

        this.ExpirationDate = DateOnly.Parse(expirationDate);
        this.ProductionDate = DateOnly.Parse(productionDate);
    }
}