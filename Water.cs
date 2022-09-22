public class Water : Product, Liquid, LimitedCapcity
{

    public float MaxCapacity { get; } = 1.5F;
    public float Quantity { get; private set; }
    public float Ph { get; private set; }
    public string WaterSource { get; private set; }
    public Water(string newName, string newDescription, double newPrice, uint newIva, double newQuantity, double newPh, string waterSource) : base(newName, newDescription, newPrice, newIva)
    {
        if (newQuantity <= this.MaxCapacity)
        {
            this.Quantity = (float)newQuantity;
        }
        else
        {
            throw new Exception("La capacità inserita supera la capacità massima di 1,5 litri");
        }

        if (newPh < 0 || newPh > 14)
        {
            throw new Exception("Il ph inserito non è valido");
        }
        else
        {
            this.Ph = (float)newPh;
        }

        this.WaterSource = waterSource;
    }

    public void Drink(double thisQuantity)
    {
        float floatQuantity = (float)thisQuantity;
        if(floatQuantity <= this.Quantity)
        {
            this.Quantity -= floatQuantity;
        } else if (this.Quantity == 0)
        {
            throw new Exception("Non puoi bere, la bottiglia è vuota");
        } else
        {
            throw new Exception("Non è possibile bere più acqua di quanto ne sia presente nella bottiglia!");
        }
    }

    public void Fill(double thisQuantity)
    {
        float floatQuantity = (float)thisQuantity;
        if(floatQuantity + this.Quantity <= this.MaxCapacity)
        {
            this.Quantity += floatQuantity;
        } else
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
        return $"{this.GetCode()} - {this.GetName()} - Sorgente: {this.WaterSource} - PH: {this.Ph} - Litri: {this.Quantity}";
    }

    public static float ToGallons(float qauntityLiters)
    {
        return qauntityLiters * 3.785F;
    }
}