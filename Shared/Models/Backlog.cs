namespace Shared.Models;

public class Backlog
{
   public string? name { get; set; }
  
   public int? UserId { get; private set; }
   public bool IsCompleted { get; set; }

   public Backlog(string? name, int? userId)
   {
      this.name = name;
      UserId = userId;
   }
}