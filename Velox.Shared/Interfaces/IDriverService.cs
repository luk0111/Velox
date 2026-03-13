namespace Velox.Shared.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Velox.Shared.DTOs;

    public interface IDriverService
    {
        Task<DriverDto?> GetDriverAsync(Guid id, CancellationToken ct = default);
        Task<IReadOnlyList<DriverDto>> ListDriversAsync(CancellationToken ct = default);
        Task<DriverDto> CreateDriverAsync(DriverDto driver, CancellationToken ct = default);
        Task UpdateDriverAsync(DriverDto driver, CancellationToken ct = default);
        Task SetDriverAvailabilityAsync(Guid driverId, bool available, CancellationToken ct = default);
    }
}
