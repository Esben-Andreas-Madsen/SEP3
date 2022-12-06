namespace Shared.DTOs;

public class UserCreationDto
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public UserCreationDto(string userName, string password, string role, string firstName, string lastName) {
        UserName = userName;
        Password = password;
        Role = role;
        FirstName = firstName;
        LastName = lastName;
    }
}