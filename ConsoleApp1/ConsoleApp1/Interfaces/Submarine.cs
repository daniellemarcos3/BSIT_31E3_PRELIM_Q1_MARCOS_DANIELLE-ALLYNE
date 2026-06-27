public class Submarine : Vehicle, ISailable, IDiveable
{
    public Submarine() { Name = "Submarine"; }
    public void Sail() { }
    public void Dive() { }
    public override string GetDescription() => "A water vehicle that sails and dives.";
}