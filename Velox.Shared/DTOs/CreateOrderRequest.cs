namespace Velox.Shared.DTOs
{
    using System;

    public class CreateOrderRequest
    {
        public string RecipientName { get; set; } = string.Empty;
        public string RecipientPhoneNumber { get; set; } = string.Empty;
        public double Weight { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public DateTime ExpectedDeliveryTime { get; set; }
        public AddressDto DeliveryAddress { get; set; } = new();
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

