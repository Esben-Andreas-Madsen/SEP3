namespace Shared.DTOs;

public class UserCreationDto
{
    public string UserName { get; }
    public string Password { get; }
    public string Role { get; }
    public string FirstName { get; }
    public string LastName { get; }

    public UserCreationDto(string userName, string password, string role, string firstName, string lastName) {
        UserName = userName;
        Password = password;
        Role = role;
        FirstName = firstName;
        LastName = lastName;
    }
}