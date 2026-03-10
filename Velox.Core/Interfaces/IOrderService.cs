namespace Velox.Core.Interfaces;

/// <summary>
/// Order application service contract.
/// Mutating methods should validate request data with DomainValidator and SystemConstants.
/// </summary>
public interface IOrderService
{
    Task<Order?> GetByIdAsync(Guid orderId);
    Task<List<Order>> GetAllPendingOrdersAsync();

    /// <summary>
    /// Creates an order after validating domain limits (weight, address, coordinates, recipient fields).
    /// </summary>
    Task<Order> CreateOrderAsync(Order order);

    Task UpdateOrderStatusAsync(Guid orderId, OrderStatus newStatus);
    Task<List<Order>> GetOrdersByRouteIdAsync(Guid routeId);
    Task<List<Order>> GetUnassignedOrdersAsync();

    /// <summary>
    /// Assigns an order to a route after route/order validation constraints are satisfied.
    /// </summary>
    Task AssignOrderToRouteAsync(Guid orderId, Guid routeId);
}