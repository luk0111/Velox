namespace Velox.Shared.DTOs
{
    using System;
    using System.Collections.Generic;

    public class RouteDto
    {
        public Guid Id { get; set; }
        public Guid DriverId { get; set; }
        public double TotalDistanceMeters { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public List<Guid> OrderIds { get; set; } = new();
    }
}

