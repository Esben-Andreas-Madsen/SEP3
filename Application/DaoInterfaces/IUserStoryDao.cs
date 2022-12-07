using Shared.DTOs;
using Shared.Models;

namespace Application.DaoInterfaces;

public interface IUserStoryDao
{
    public Task<IEnumerable<UserStory>> GetAsync();
    Task<UserStoryCreationDto> CreateAsync(UserStoryCreationDto dto);

}