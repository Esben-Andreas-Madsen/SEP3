using Application.DaoInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace Database.DAOs;

public class UserStoryDao : IUserStoryDao
{
    private readonly DataContainer container;
    private DataContext context;

    public UserStoryDao(DataContainer container, DataContext context)
    {
        this.container = container;
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