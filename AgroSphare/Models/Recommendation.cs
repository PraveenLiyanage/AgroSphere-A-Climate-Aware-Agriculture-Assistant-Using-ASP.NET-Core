namespace AgroSphare.Models
{
    public class Recommendation
    {
        public int Id { get; set; }
        public string Advice { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CropType { get; set; }
    }
}
