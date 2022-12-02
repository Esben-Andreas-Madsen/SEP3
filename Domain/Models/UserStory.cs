namespace Domain.Models;

public class UserStory
{
    public int UserStoryId { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public UserStory(int userStoryId, int userId, string title, string description)
    {
        UserStoryId = userStoryId;
        UserId = userId;
        Title = title;
        Description = description;
    }
    

    public override string ToString()
    {
        return $"{nameof(UserStoryId)}: {UserStoryId}, {nameof(UserId)}: {UserId}, {nameof(Title)}: {Title}, {nameof(Description)}: {Description}";
    }
}