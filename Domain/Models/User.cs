using System.Text.Json.Serialization;

namespace Domain.Models;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    private string Password { get; set; }
    public string Role { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public User(int userId, string userName, string password, string role, string firstName, string lastName) {
        UserId = userId;
        UserName = userName;
        Password = password;
        Role = role;
        FirstName = firstName;
        LastName = lastName;
    }
    
    public User(string userName, string password, string role, string firstName, string lastName) {
        UserName = userName;
        Password = password;
        Role = role;
        FirstName = firstName;
        LastName = lastName;
    }
  
    // [JsonIgnore]
    // public ICollection<Backlog> Backlogs { get; set; }
}