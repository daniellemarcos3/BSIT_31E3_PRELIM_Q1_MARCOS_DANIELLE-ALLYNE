public class Car : Vehicle, IDriveable
{
    public Car()
    {
        Name = "Car";
    }
 
    public void Drive()
    {
        // Implementation
    }
 
    public override string GetDescription()
    {
        return "A vehicle that drives on roads.";
    }
}