namespace Velox.Shared.DTOs
{
    using Velox.Shared.Enums;
    using System;

    public class UpdateOrderStatusRequest
    {
        public Guid OrderId { get; set; }
        public OrderStatus NewStatus { get; set; }
    }
}

