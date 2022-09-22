public class Water : Product
{

    public float Quantity { get; private set; }
    private float maxCapacity = 1.5F;
    public Water(string newName, string newDescription, float newPrice, uint newIva, double newQuantity) : base(newName, newDescription, newPrice, newIva)
    {
        if(newQuantity <= this.maxCapacity)
        {
            this.Quantity = (float)newQuantity;
        } else
        {
            throw new Exception("La capacità inserita supera la capacità massima di 1,5 litri");
        }
    }
}