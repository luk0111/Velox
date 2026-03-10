namespace Velox.Core;

public class Order
{
    //date to deliver, recipient name and phone number, weight, dimensions
    //adress
    public Guid Id { get; set; }
    public string RecipientName { get; set; } = string.Empty;
    public string RecipientPhoneNumber { get; set; } = string.Empty;
    public double Weight { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public DateTime ExpectedDeliveryTime { get; set; } 
    public string DestinationAdress { get; set; } = string.Empty;
    
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    
    public OrderStatus Status { get; set; }
    
    public Route Route { get; set; } = null!;
    public Guid? RouteID { get; set; }
}