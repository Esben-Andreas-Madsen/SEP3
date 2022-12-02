using Application.DaoInterfaces;
using Domain.DTOs;
using Domain.Models;

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
        await context.createBacklog(dto);
        return await Task.FromResult(dto);
    }


    public Task<IEnumerable<Backlog>> GetAsync(SearchBacklogParametersDto searchParameters)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Backlog backlog)
    {
        throw new NotImplementedException();
    }

    public Task<Backlog?> GetByNameAsync(string backlogName)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string backlogName)
    {
        throw new NotImplementedException();
    }
}