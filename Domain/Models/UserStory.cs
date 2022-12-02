namespace Domain.Models;

public class UserStory
{
    private int UserStoryId { get; set; }
    private int UserId { get; set; }
    private string Title { get; set; }
    private string Description { get; set; }

    public UserStory(int userStoryId, int userId, string title, string description)
    {
        UserStoryId = userStoryId;
        UserId = userId;
        Title = title;
        Description = description;
    }

    public UserStory(int userId, string title, string description)
    {
        UserId = userId;
        Title = title;
        Description = description;
    }

    public override string ToString()
    {
        return $"{nameof(UserStoryId)}: {UserStoryId}, {nameof(UserId)}: {UserId}, {nameof(Title)}: {Title}, {nameof(Description)}: {Description}";
    }
}