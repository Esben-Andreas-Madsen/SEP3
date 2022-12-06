using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

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
            var todos = await backlogLogic.GetAsync();
            return Ok(todos);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}