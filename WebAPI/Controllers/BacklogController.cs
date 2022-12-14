using Application.LogicInterfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;
using Shared.Models;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BacklogController: ControllerBase
{
    private readonly IBacklogLogic backlogLogic;

    public BacklogController(IBacklogLogic backlogLogic)
    {
        this.backlogLogic = backlogLogic;
    }
    
    [HttpPost]
    public async Task<ActionResult<Backlog>> CreateAsync([FromBody]BacklogCreationDto dto)
    {
        try
        {
            BacklogCreationDto backlog = await backlogLogic.CreateAsync(dto);
            return Created($"/backlog/{backlog.Title}", backlog);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Backlog>>> GetAsync()
    {
        try
        {
            var backlogs = await backlogLogic.GetAsync();
            return Ok(backlogs);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }


    [HttpPost("AssignBacklog")]
    public async Task<ActionResult<AssignUserStoryDto>> AssignUserStory([FromBody]AssignUserStoryDto dto)
    {
        try
        {
            AssignUserStoryDto backlog = await backlogLogic.AssignUserStory(dto);
            return Created($"/backlog/{backlog.BacklogName}", backlog);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}