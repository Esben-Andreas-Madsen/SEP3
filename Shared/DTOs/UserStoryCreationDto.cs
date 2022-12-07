namespace Shared.DTOs;

public class UserStoryCreationDto
{
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public UserStoryCreationDto(int userId, string title, string description)
    {
        UserId = userId;
        Title = title;
        Description = description;
    }
    
    public override string ToString()
    {
        return $"{nameof(UserId)}: {UserId}, {nameof(Title)}: {Title}, {nameof(Description)}: {Description}";
    }
}