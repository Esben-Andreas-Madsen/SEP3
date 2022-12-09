using Shared.DTOs;
using Shared.Models;

namespace HttpClients.ClientInterfaces;

public interface IBackLogService
{
    Task CreateAsync(BacklogCreationDto dto);
    Task<IEnumerable<Backlog>?> GetAsync();
}