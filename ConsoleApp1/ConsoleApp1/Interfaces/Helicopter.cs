public class Helicopter : Vehicle, IFlyable, IDriveable
{
    public Helicopter()
    {
        Name = "Helicopter";
    }
 
    public void Fly()
    {
        // Implementation
    }
 
    public void Drive()
    {
        // Implementation
    }
 
    public override string GetDescription()
    {
        return "A vehicle that can both fly and drive.";
    }
}