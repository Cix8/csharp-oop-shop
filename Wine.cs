public class Wine : Product, ILiquid, ILimitedCapacity
{

    public float MaxCapacity { get; } = 0.75F;
    public float Quantity { get; private set; }
    public float AlcoholPercentage { get; private set; }
    public string Winery { get; private set; }
    public Wine(string newName, string newDescription, double newPrice, uint newIva, double newQuantity, double alcoholPercentage, string winery) : base(newName, newDescription, newPrice, newIva)
    {
        if (newQuantity <= this.MaxCapacity)
        {
            this.Quantity = (float)newQuantity;
        }
        else
        {
            throw new Exception("La capacità inserita supera la capacità massima di 1,5 litri");
        }

        this.AlcoholPercentage = (float)alcoholPercentage;
        this.Winery = winery;
    }

    public void Drink(double thisQuantity)
    {
        float floatQuantity = (float)thisQuantity;
        if (floatQuantity <= this.Quantity)
        {
            this.Quantity -= floatQuantity;
        }
        else if (this.Quantity == 0)
        {
            throw new Exception("Non puoi bere, la bottiglia è vuota");
        }
        else
        {
            throw new Exception("Non è possibile bere più acqua di quanto ne sia presente nella bottiglia!");
        }
    }

    public void Fill(double thisQuantity)
    {
        float floatQuantity = (float)thisQuantity;
        if (floatQuantity + this.Quantity <= this.MaxCapacity)
        {
            this.Quantity += floatQuantity;
        }
        else
        {
            throw new Exception("Non posso riempire così tanto la bottiglia, andrebbe oltre la sua capacità massima");
        }
    }

    public void Empty()
    {
        this.Quantity = 0;
    }

    public override string GetFullName()
    {
        return $"{this.GetCode()} - {this.GetName()} - Sorgente: {this.Winery} - PH: {this.AlcoholPercentage} - Litri: {this.Quantity}";
    }
}