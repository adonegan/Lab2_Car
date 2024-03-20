namespace Lab2_Car.Models
{
    public enum EngineTypes
    {
        Petrol, Diesel, Hybrid
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public EngineTypes Type { get; set; }
        public string EngineSize { get; set; }
    }
}
