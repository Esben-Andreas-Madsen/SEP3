using Domain.Models;
using LoadDatabase;

namespace Database;

public interface FormatterInterface
{
    User responseToUser(UserResponse response);
    UserStory responseToUserStory(UserStoryResponse response);
    Backlog responseToBacklog(BacklogResponse response);
}