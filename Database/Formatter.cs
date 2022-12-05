using Domain.Models;
using LoadDatabase;

namespace Database;

public class Formatter : FormatterInterface
{
    public User responseToUser(UserResponse response)
    {
        return new User(response.UserId,response.UserName, response.Password, response.Role, response.FirstName, response.LastName);
    }

    public UserStory responseToUserStory(UserStoryResponse response)
    { 
        return new UserStory(response.UserStoryId,response.UserId, response.Title, response.Description);
    }

    public Backlog responseToBacklog(BacklogResponse response)
    {
        return new Backlog(response.BacklogName, response.UserId);
    }

    /*public Backlog responseToBacklog(BacklogResponse response)
    {
        return new Backlog(response.BacklogName,response.UserStoryId,response.UserId);
    }*/
}