using Application.DaoInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class UserLogic : IUserLogic
{
    private readonly IUserDao userDao;

    public UserLogic(IUserDao userDao)
    {
        this.userDao = userDao;
    }

    private static void ValidateData(UserCreationDto dto)
    {
        string? userName = dto.UserName;

        if (userName.Length < 3)
            throw new Exception("Username must be at least 3 characters!");

        if (userName.Length > 15)
            throw new Exception("Username must be less than 16 characters!");
    }

    public Task<UserCreationDto> CreateAsync(UserCreationDto dto)
    {
        ValidateData(dto);
        return userDao.CreateAsync(dto);
    }

    public Task<IEnumerable<User>> GetAsync()
    {
        return userDao.GetAsync();
    }

    public Task<User?> GetByUserNameAsync(string userName)
    {
        return userDao.GetByUsernameAsync(userName);
    }
}