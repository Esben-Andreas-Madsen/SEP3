namespace Shared.DTOs;

public class AssignUserStoryDto
{
    public string BacklogName { get; set; }
    public int UserStoryId { get; set; }
    public int UserId { get; set; }

    public AssignUserStoryDto(string backlogName, int userStoryId, int userId)
    {
        BacklogName = backlogName;
        UserStoryId = userStoryId;
        UserId = userId;
    }

    public override string ToString()
    {
        return $"{nameof(BacklogName)}: {BacklogName}, {nameof(UserStoryId)}: {UserStoryId}, {nameof(UserId)}: {UserId}";
    }
}