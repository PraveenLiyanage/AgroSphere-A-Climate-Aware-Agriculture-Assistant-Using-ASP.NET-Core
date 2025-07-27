namespace AgroSphare.Models
{
    public class SoilData
    {
        public int Id { get; set; }
        public string SoilType { get; set; }
        public float pH { get; set; }
        public float MoistureLevel { get; set; }
        public DateTime CollectedAt { get; set; }
    }
}
