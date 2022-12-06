using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface IBacklogLogic
{
   Task<BacklogCreationDto> CreateAsync(BacklogCreationDto dto);
   public Task<IEnumerable<Backlog>> GetAsync();
}