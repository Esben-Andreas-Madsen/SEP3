namespace Shared.Models;

public class Backlog
{
   public string BacklogName { get; init; }
   public int UserStoryId { get; init; }
   public int UserId { get; init; }

   public Backlog(string backlogName, int userStoryId, int userId)
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