namespace Velox.Shared.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Velox.Shared.DTOs;
    using Velox.Shared.Enums;

    public interface IOrderService
    {
        Task<OrderDto?> GetOrderAsync(Guid id, CancellationToken ct = default);
        Task<IReadOnlyList<OrderDto>> ListOrdersAsync(CancellationToken ct = default);
        Task<OrderDto> CreateOrderAsync(OrderDto order, CancellationToken ct = default);
        Task UpdateOrderStatusAsync(Guid orderId, OrderStatus newStatus, CancellationToken ct = default);
        Task AssignDriverAsync(Guid orderId, Guid driverId, CancellationToken ct = default);
    }
}
