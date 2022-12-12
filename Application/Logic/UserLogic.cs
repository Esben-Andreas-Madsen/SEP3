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
        string userName = dto.UserName;
        string password = dto.Password;
        string role = dto.Role;
        string fname = dto.FirstName;
        string lname = dto.LastName;


        if (userName.Length < 7)
            throw new Exception("Username must be at least 7 characters!");
        if (userName.Length > 15)
            throw new Exception("Username must be less than 16 characters!");

        if (password.Length < 7)
            throw new Exception("Password must be at least 7 characters!");
        if (password.Length > 15)
            throw new Exception("Password must be less than 15 characters!");
        
        if (role.Length < 4)
            throw new Exception("Role must be at least 4 characters!");
        
        if (fname.Length < 3)
            throw new Exception("Firstname must be at least 3 characters!");
        if (fname.Length > 40)
            throw new Exception("Firstname must be less than 40 characters!");
        
        if (lname.Length < 3)
            throw new Exception("Lastname must be at least 3 characters!");
        if (lname.Length > 40)
            throw new Exception("Lastname must be less than 40 characters!");
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