using Shared.Models;

namespace Database;

public class DataContainer
{
    public List<User> Users { get; }
    public List<UserStory> UserStories { get; }
    public List<Backlog> Backlogs { get; }

    public DataContainer()
    {
        Users = new List<User>();
        UserStories = new List<UserStory>();
        Backlogs = new List<Backlog>();
    }
}