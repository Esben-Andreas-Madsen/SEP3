using Domain.DTOs;
using Domain.Models;

namespace Application.DaoInterfaces;

public interface IBacklogDao
{
    Task<BacklogCreationDto> CreateAsync(BacklogCreationDto dto);
     Task<IEnumerable<Backlog>> GetAsync();
    Task UpdateAsync(Backlog backlog);
    Task<Backlog?> GetByNameAsync(string backlogName);
    Task DeleteAsync(string backlogName);
    
}