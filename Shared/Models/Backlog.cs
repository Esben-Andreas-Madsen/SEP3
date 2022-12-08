namespace Shared.Models;

public class Backlog
{
   public string BacklogName { get; set; }
   public int UserStoryId { get; set; }
   public int UserId { get; set; }

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