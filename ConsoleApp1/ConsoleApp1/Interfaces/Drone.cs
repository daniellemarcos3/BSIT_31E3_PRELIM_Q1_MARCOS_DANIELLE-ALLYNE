public class Drone : Vehicle, IFlyable
{
    public Drone() { Name = "Drone"; }
    public void Fly() { }
    public override string GetDescription() => "An unmanned flying device.";
}