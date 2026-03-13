namespace Velox.Core.Interfaces;

public interface IOrderService
{
    Task<Order?> GetByIdAsync(Guid orderId);
    Task<List<Order>> GetAllPendingOrdersAsync();
    Task<Order> CreateOrderAsync(Order order);
    Task UpdateOrderStatusAsync(Guid orderId, OrderStatus newStatus);
    Task<List<Order>> GetOrdersByRouteIdAsync(Guid routeId);
    Task<List<Order>> GetUnassignedOrdersAsync();
    Task AssignOrderToRouteAsync(Guid orderId, Guid routeId);
    
}