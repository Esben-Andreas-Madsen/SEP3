using Shared.Models;

namespace Database;

public class DataContainer
{
    public List<User> Users { get; set; }
    public List<UserStory> UserStories { get; set; }
    public List<Backlog> Backlogs { get; set; }

    public DataContainer()
    {
        Users = new List<User>();
        UserStories = new List<UserStory>();
        Backlogs = new List<Backlog>();
    }
}