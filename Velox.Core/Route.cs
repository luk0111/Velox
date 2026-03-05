namespace Velox.Core;

public class Route
{
    public Guid DriverId { get; set; }
    public Guid Id { get; set; }
    //route optimizat (probabil json/encoded cumva)
    
    public double TotalDistanceMeters { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    
    public Driver Driver { get; set; }
    public List<Order> Orders { get; set; }
}