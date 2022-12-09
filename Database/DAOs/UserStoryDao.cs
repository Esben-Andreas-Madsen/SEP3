using Application.DaoInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Database.DAOs;

public class UserStoryDao : IUserStoryDao
{
    private DataContext context;

    public UserStoryDao(DataContext context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<UserStory>> GetAsync()
    {
        await context.GetAllUserStories();
        IEnumerable<UserStory> userStories = context.container.UserStories;
        return await Task.FromResult(userStories);
    }

    public async Task<UserStoryCreationDto> CreateAsync(UserStoryCreationDto dto)
    {
        await context.CreateUserStory(dto);
        return await Task.FromResult(dto);
    }
}