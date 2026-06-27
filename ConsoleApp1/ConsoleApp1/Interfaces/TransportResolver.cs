public static class TransportResolver
{
    public static Vehicle? Resolve(string transportType)
    {
        return transportType.ToLower() switch
        {
            "car" => new Car(),
            "plane" => new Airplane(),
            "boat" => new Boat(),
            "helicopter" => new Helicopter(),
            // Bonus additions
            "motorcycle" => new Motorcycle(),
            "submarine" => new Submarine(),
            "drone" => new Drone(),
            // Return null for invalid input (no crash)
            _ => null
        };
    }
}