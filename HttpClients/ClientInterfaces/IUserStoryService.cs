using Shared.DTOs;
using Shared.Models;

namespace HttpClients.ClientInterfaces;

public interface IUserStoryService
{
    Task<UserStory> Create(UserStoryCreationDto dto);
    
    Task<IEnumerable<UserStory>> GetUsers();
}