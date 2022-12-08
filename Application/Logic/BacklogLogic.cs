using Application.DaoInterfaces;
using Application.LogicInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace Application.Logic;

public class BacklogLogic: IBacklogLogic
{
    private readonly IBacklogDao backlogDao;

    public BacklogLogic(IBacklogDao backlogDao)
    {
        this.backlogDao = backlogDao;
    }
    
    public Task<BacklogCreationDto> CreateAsync(BacklogCreationDto dto)
    {
        ValidateBacklog(dto);
        return backlogDao.CreateAsync(dto);
    }
    

    public Task<IEnumerable<Backlog>> GetAsync()
    {
        return backlogDao.GetAsync();
    }


    private void ValidateBacklog(BacklogCreationDto dto)
    {
        if (string.IsNullOrEmpty(dto.Title)) throw new Exception("Name cannot be empty.");
    }

    public Task<AssignUserStoryDto> AssignUserStory(AssignUserStoryDto dto)
    {
        return backlogDao.AssignUserStory(dto);
    }

}