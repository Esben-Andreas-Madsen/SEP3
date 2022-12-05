using Domain.Models;

namespace Domain.DTOs;

public class BacklogUpdateDto
{
    
    //todo få sty rpå id/name
    public int Id { get; }
    public int? userID { get; set; }
    public string? Name { get; set; }
    public bool? IsCompleted { get; set; }

    public BacklogUpdateDto(string name)
    {
        Name = name;
    }
}