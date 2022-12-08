namespace Shared.DTOs;

public class BacklogCreationDto
{
    public int UserId { get; set; }
    public string Title { get; set; }


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