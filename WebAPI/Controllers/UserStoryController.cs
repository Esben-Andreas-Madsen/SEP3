using Application.LogicInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Models;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserStoryController : ControllerBase
{
    private readonly IUserStoryLogic userStoryLogic;

    public UserStoryController(IUserStoryLogic userStoryLogic)
    {
        this.userStoryLogic = userStoryLogic;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserStory>>> GetAsync()
    {
        try
        {
            IEnumerable<UserStory> userStories = await userStoryLogic.GetAsync();
            return Ok(userStories);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpPost]
    public async Task<ActionResult<UserStory>> CreateAsync(UserStoryCreationDto dto)
    {
        try
        {
            UserStoryCreationDto userStory = await userStoryLogic.CreateAsync(dto);
            return Created($"/userstory/{userStory.Title}", userStory);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}