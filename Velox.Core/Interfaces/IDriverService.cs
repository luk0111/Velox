using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Velox.Core.Interfaces;

public interface IDriverService
{
    Task<Driver?> GetByIdAsync(Guid driverId);
    
    //AI primeste un driver si o lista da ordere - 
    //acesta optimizeaza traseul astfel incat acesta 
    //sa fie cat mai liniar, scurt, nonredundant
    Task<List<Order>> OptimizeRouteAsync(Driver driver, List<Order> orders);
    Task<Route> AssignOrdersToDriverAsync(Driver driver, List<Order> orders);
    Task UpdateLocationAsync(Guid driverId, double latitude, double longitude);
    
    Task<Route?> GetCurrentRouteAsync(Guid driverId);
    
}