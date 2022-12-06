using Domain.DTOs;
using Domain.Models;

namespace Application.DaoInterfaces;

public interface IUserDao
{
    Task<UserCreationDto> CreateAsync(UserCreationDto dto);
    Task<User?> GetByUsernameAsync(string? userName);
    public Task<IEnumerable<User>> GetAsync();
    
}