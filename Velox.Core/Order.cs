namespace Velox.Core;

public class Order
{
    //date to deliver, recipient name and phone number, weight, dimensions
    //adress
    public Guid Id { get; set; }
    public string RecipientName { get; set; }
    public string RecipientPhoneNumber { get; set; }
    public double Weight { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public DateTime ExpectedDeliveryTime { get; set; } 
    public string DestinationAdress { get; set; }
}