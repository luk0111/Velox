namespace Velox.Shared.DTOs
{
    using System;
    using Velox.Shared.Enums;

    public class OrderDto
    {
        public Guid Id { get; set; }
        public string RecipientName { get; set; } = string.Empty;
        public string RecipientPhoneNumber { get; set; } = string.Empty;
        public double Weight { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public DateTime ExpectedDeliveryTime { get; set; }
        public string DestinationAddress { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public OrderStatus Status { get; set; }
        public Guid? RouteId { get; set; }
    }
}

