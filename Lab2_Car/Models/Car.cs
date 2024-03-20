namespace Lab2_Car.Models
{
    public enum EngineType
    {
        Petrol, Diesel, Hybrid
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public EngineType Type { get; set; }
        public string EngineSize { get; set; }
    }
}
