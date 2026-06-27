public class Motorcycle : Vehicle, IDriveable
{
    public Motorcycle() { Name = "Motorcycle"; }
    public void Drive() { }
    public override string GetDescription() => "Two-wheeled road vehicle.";
}
 