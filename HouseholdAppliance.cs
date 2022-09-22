public class HouseholdAppliance : Product
{

    public string EnergyRating { get; private set; }
    public DateOnly ManufacturingDate { get; private set; }
    public HouseholdAppliance(string newName, string newDescription, double newPrice, uint newIva, string energyRating, string manufacturingDate) : base(newName, newDescription, newPrice, newIva)
    {
        this.EnergyRating = energyRating;
        this.ManufacturingDate = DateOnly.Parse(manufacturingDate);
    }
}