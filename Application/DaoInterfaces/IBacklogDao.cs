using Shared.DTOs;
using Shared.Models;

namespace Application.DaoInterfaces;

public interface IBacklogDao
{
    Task<BacklogCreationDto> CreateAsync(BacklogCreationDto dto);
     Task<IEnumerable<Backlog>> GetAsync();
    Task UpdateAsync(Backlog backlog);
    Task<Backlog?> GetByNameAsync(string backlogName);
    Task DeleteAsync(string backlogName);
    
}