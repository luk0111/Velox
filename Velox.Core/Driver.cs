using System;
using System.Collections.Generic;
namespace Velox.Core;

public class Driver
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double MaxLoad { get; set; }
    public List<Order> Orders { get; set; }
}