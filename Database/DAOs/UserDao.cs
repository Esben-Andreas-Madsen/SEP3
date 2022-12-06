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
    
    
    public Task<User?> GetByUsernameAsync(string? userName)
    {
        User? existing = container.Users!.FirstOrDefault(u =>
            u.UserName != null && u.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
        );
        return Task.FromResult(existing);
    }
}