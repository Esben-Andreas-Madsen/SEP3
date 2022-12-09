namespace Shared.DTOs;

public class AssignUserStoryDto
{
    public string BacklogName { get; init; }
    public int UserStoryId { get; init; }
    public int UserId { get; init; }

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