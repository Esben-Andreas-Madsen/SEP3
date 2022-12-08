using Shared.DTOs;
using Shared.Models;

namespace Application.DaoInterfaces;

public interface IBacklogDao
{
    Task<BacklogCreationDto> CreateAsync(BacklogCreationDto dto);
     Task<IEnumerable<Backlog>> GetAsync();
     Task<AssignUserStoryDto> AssignUserStory(AssignUserStoryDto dto);

}