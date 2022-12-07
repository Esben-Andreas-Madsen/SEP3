using Shared.DTOs;
using Shared.Models;

namespace Application.LogicInterfaces;

public interface IUserStoryLogic
{
    public Task<IEnumerable<UserStory>> GetAsync();
    Task<UserStoryCreationDto> CreateAsync(UserStoryCreationDto dto);

    
}