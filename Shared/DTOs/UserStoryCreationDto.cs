namespace Shared.DTOs;

public class UserStoryCreationDto
{
    public int UserId { get; init; }
    public string Title { get; init; }
    public string Description { get; init; }

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