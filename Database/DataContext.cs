using Grpc.Core;
using Grpc.Net.Client;
using LoadDatabase;
using Shared.DTOs;

namespace Database;

public class DataContext
{
    private HttpClientHandler handler;
    private ScrumService.ScrumServiceClient client;
    private GrpcChannel channel;
    private Formatter formatter;
    public DataContainer container { get; }

    public DataContext()
    {
        handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback =
            HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

        channel = GrpcChannel.ForAddress("http://localhost:9090", new GrpcChannelOptions { HttpHandler = handler });
        client = new ScrumService.ScrumServiceClient(channel);
        container = new DataContainer();
        formatter = new Formatter();
    }

    public async Task GetAllBacklogs()
    {
        AsyncServerStreamingCall<BacklogResponse> streamingCall = client.getAllBacklogs(new AllBacklogsRequest());
        try
        {
            await foreach (BacklogResponse backlogResponse in streamingCall.ResponseStream.ReadAllAsync())
            {
                container.Backlogs.Add(formatter.responseToBacklog(backlogResponse));
            }
        }
        catch (RpcException ex)
        {
            Console.WriteLine(ex);
        }

        await Task.FromResult(streamingCall);
    }
    
    public async Task GetAllUsers()
    {
        AsyncServerStreamingCall<UserResponse> streamingCall = 
            client.getAllUsers(new AllUsersRequest());
        try
        {
            await foreach (UserResponse userResponse in 
                           streamingCall.ResponseStream.ReadAllAsync())
            {
                container.Users
                    .Add(formatter.responseToUser(userResponse));
            }
        }
        catch (RpcException ex)
        {
            Console.WriteLine(ex);
        }

        await Task.FromResult(streamingCall);
    }
    
    public async Task GetAllUserStories()
    {
        AsyncServerStreamingCall<UserStoryResponse> streamingCall = 
            client.getAllUserStories(new AllUserStoriesRequest());
        
        try
        {
            await foreach (UserStoryResponse userStoryResponse in 
                           streamingCall.ResponseStream.ReadAllAsync())
            {
                container.UserStories
                    .Add(formatter.responseToUserStory(userStoryResponse));
            }
        }
        catch (RpcException ex)
        {
            Console.WriteLine(ex);
        }

        await Task.FromResult(streamingCall);
    }

    public Task CreateUser(UserCreationDto dto)
    {
        client.createUser(new NewUserRequest()
        {
            UserName = dto.UserName, Password = dto.Password, Role = dto.Role,FirstName = dto.FirstName,LastName = dto.LastName
        });
        return Task.FromResult(dto);

    }

    public async Task CreateBacklog(BacklogCreationDto dto)
    {
        client.createBacklog(new NewBacklogRequest()
        {
            BacklogName = dto.Title, UserId = dto.UserId
        });
        await Task.FromResult(dto);
    }

    public async Task CreateUserStory(UserStoryCreationDto dto)
    {
        client.createUserStory(new NewUserStoryRequest()
        {
            UserId = dto.UserId, Title = dto.Title, Description = dto.Description
        });
        await Task.FromResult(dto);
    }

    public async Task AssignUserStory(AssignUserStoryDto dto)
    {
        client.assignUserStory(new AssignUserStoryToBacklog()
        {
            BacklogName = dto.BacklogName, UserStoryId = dto.UserStoryId, UserId = dto.UserId
        });
        await Task.FromResult(dto);
    }
}