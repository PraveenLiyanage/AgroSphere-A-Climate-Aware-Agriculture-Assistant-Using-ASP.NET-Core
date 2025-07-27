namespace AgroSphare.Models
{
    public class YieldPrediction
    {
        public int Id { get; set; }
        public string CropType { get; set; }
        public float PredictedYield { get; set; }
        public DateTime PredictionDate { get; set; }
    }
}
