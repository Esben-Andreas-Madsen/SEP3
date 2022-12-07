using Database;
using Shared.Models;
namespace WebAPI.Services;

public class AuthService : IAuthService
{
    private DataContext context;

    public AuthService(DataContext context)
    {
        this.context = context;
    }

    public async Task<User> ValidateUser(string username, string password)
    {
        await context.GetAllUsers();
        User? existingUser = context.container.Users.FirstOrDefault(u => 
            u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase));
        
        if (existingUser == null)
        {
            throw new Exception("User not found");
        }

        if (!existingUser.Password.Equals(password))
        {
            throw new Exception("Password mismatch");
        }

        return await Task.FromResult(existingUser);
    }
}