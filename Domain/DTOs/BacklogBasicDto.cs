using Domain.Models;

namespace Domain.DTOs;

public class BacklogBasicDto
{
    public string? name { get; set; }
   
    public int? userId { get;  set; }
    public bool IsCompleted { get; set; }

    public BacklogBasicDto(string? name, int? userId, bool isCompleted)
    {
        this.name = name;
        this.userId = userId;
        IsCompleted = isCompleted;
    }
}