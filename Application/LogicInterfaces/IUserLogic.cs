using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public interface IUserLogic
{
    Task<UserCreationDto> CreateAsync(UserCreationDto dto);
    public Task<IEnumerable<User>> GetAsync();

    Task<User?> GetByUserNameAsync(string userName);
}