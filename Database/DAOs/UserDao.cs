using System.Security.AccessControl;
using Application.DaoInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace Database.DAOs;

public class UserDao : IUserDao

{
    private readonly DataContainer container;
    private DataContext context;

    public UserDao(DataContainer container, DataContext context)
    {
        this.container = container;
        this.context = context;
    }

    public async Task<UserCreationDto> CreateAsync(UserCreationDto dto)
    {
        await context.CreateUser(dto);
        return await Task.FromResult(dto);
    }
    
    public async Task<IEnumerable<User>> GetAsync()
    {
        await context.GetAllUsers();
        IEnumerable<User> users = context.container.Users;
        return await Task.FromResult(users);
    }
    
    
    public async Task<User?> GetByUsernameAsync(string? userName)
    {
        await context.GetAllUsers();
        User? existing = null;
        foreach (User user in context.container.Users)
        {
            if (user.UserName.ToLower().Equals(userName.ToLower()))
            {
                existing = user;
            }
        }

        return await Task.FromResult(existing);
    }
}