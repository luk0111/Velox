namespace Velox.Shared.DTOs
{
    using System;

    public class DriverDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public bool Available { get; set; } = true;
        public double CurrentLatitude { get; set; }
        public double CurrentLongitude { get; set; }
    }
}

