namespace Velox.Core;

public class Route
{
    public string DriverId { get; set; }
    public Guid Id { get; set; }
    //route optimizat (probabil json/encoded cumva)
    
    public double TotalDistanceMeters { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    
}