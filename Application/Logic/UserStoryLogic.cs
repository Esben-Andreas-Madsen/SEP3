using Application.DaoInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class UserStoryLogic : IUserStoryLogic
{
    private IUserStoryDao userStoryDao;

    public UserStoryLogic(IUserStoryDao userStoryDao)
    {
        this.userStoryDao = userStoryDao;
    }


    public Task<IEnumerable<UserStory>> GetAsync()
    {
        return userStoryDao.GetAsync();
    }

    public Task<UserStoryCreationDto> CreateAsync(UserStoryCreationDto dto)
    {
        return userStoryDao.CreateAsync(dto);
    }
}