namespace Velox.Shared.DTOs
{
    using System;

    public class UpdateDriverRequest
    {
        public Guid DriverId { get; set; }
        public bool Available { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}

