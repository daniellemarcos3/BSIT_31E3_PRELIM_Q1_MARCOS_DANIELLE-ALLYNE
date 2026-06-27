public class Boat : Vehicle, ISailable
{
    public Boat()
    {
        Name = "Boat";
    }
 
    public void Sail()
    {
        // Implementation
    }
 
    public override string GetDescription()
    {
        return "A vehicle that sails on water.";
    }
}