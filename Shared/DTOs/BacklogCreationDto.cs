namespace Shared.DTOs;

public class BacklogCreationDto
{
    public int UserId { get; init; }
    public string Title { get; init; }


    public BacklogCreationDto(int userId, string title)
    {
        UserId = userId;
        Title = title;
    }
    

    public override string ToString()
    {
        return $"{nameof(UserId)}: {UserId}, {nameof(Title)}: {Title}";
    }
}