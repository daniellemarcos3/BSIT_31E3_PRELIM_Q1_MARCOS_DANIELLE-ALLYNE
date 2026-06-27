public class Airplane : Vehicle, IFlyable
{
    public Airplane()
    {
        Name = "Airplane";
    }
 
    public void Fly()
    {
        // Implementation
    }
 
    public override string GetDescription()
    {
        return "A vehicle that flies through the air.";
    }
}