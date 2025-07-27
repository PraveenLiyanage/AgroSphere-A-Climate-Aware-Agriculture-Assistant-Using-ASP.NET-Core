namespace AgroSphare.Models
{
    public class WeatherLog
    {
        public int Id { get; set; }
        public DateTime RecordedAt { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Rainfall { get; set; }
        public string Location { get; set; }
    }
}
