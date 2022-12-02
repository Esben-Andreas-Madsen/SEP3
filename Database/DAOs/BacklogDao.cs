using Application.DaoInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace Database.DAOs;

public class BacklogDao : IBacklogDao
{

    private readonly DataContainer container;
    public Task<Backlog> CreateAsync(Backlog backlog)
    {
        container.Backlogs.Add(backlog);
        return Task.FromResult(backlog);
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