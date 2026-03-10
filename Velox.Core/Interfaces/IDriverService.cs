using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Velox.Core.Interfaces;

/// <summary>
/// Driver application service contract.
/// Route-related operations should validate driver/order constraints from SystemConstants.
/// </summary>
public interface IDriverService
{
    Task<Driver?> GetByIdAsync(Guid driverId);

    // AI receives a driver and a list of orders and returns a linear/non-redundant optimized order sequence.
    Task<List<Order>> OptimizeRouteAsync(Driver driver, List<Order> orders);

    /// <summary>
    /// Assigns orders to a driver only if assignment respects route size and load limits.
    /// </summary>
    Task<Route> AssignOrdersToDriverAsync(Driver driver, List<Order> orders);

    Task UpdateLocationAsync(Guid driverId, double latitude, double longitude);
    Task<Route?> GetCurrentRouteAsync(Guid driverId);
}