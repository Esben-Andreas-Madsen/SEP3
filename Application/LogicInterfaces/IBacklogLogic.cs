using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public interface IBacklogLogic
{
   Task<BacklogCreationDto> CreateAsync(BacklogCreationDto dto);
   public Task<IEnumerable<Backlog>> GetAsync();
   Task UpdateAsync(BacklogUpdateDto dto);
   Task DeleteAsync(string? name);
   Task<BacklogBasicDto> GetByNameAsync(string? backlogName);
}