using Application.DaoInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Database.DAOs;

public class BacklogDao : IBacklogDao
{

    private readonly DataContainer container;
    private DataContext context;

    public BacklogDao(DataContainer container, DataContext context)
    {
        this.container = container;
        this.context = context;
    }

    public async Task<BacklogCreationDto> CreateAsync(BacklogCreationDto dto)
    {
        await context.CreateBacklog(dto);
        return await Task.FromResult(dto);
    }


    public async Task<IEnumerable<Backlog>> GetAsync()
    {
        await context.GetAllBacklogs();
        IEnumerable<Backlog> backlogs = context.container.Backlogs;
        return await Task.FromResult(backlogs);
    }

    public async Task<AssignUserStoryDto> AssignUserStory(AssignUserStoryDto dto)
    {
        await context.AssignUserStory(dto);
        return await Task.FromResult(dto);
    }
}