using System.Net.Http.Json;
using System.Text.Json;
using HttpClients.ClientInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace HttpClients.Implementations;

public class UserStoryHttpClient : IUserStoryService
{
    
    private readonly HttpClient client;
    
    public UserStoryHttpClient(HttpClient client)
    {
        this.client = client;
    }
    public async Task<UserStory> Create(UserStoryCreationDto dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/userStory", dto);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        UserStory userStory = JsonSerializer.Deserialize<UserStory>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return userStory;
    }

    public async Task<IEnumerable<UserStory>> GetUserStories()
    {
        string uri = "/userstory";
        HttpResponseMessage response = await client.GetAsync(uri);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        IEnumerable<UserStory> userStories = JsonSerializer.Deserialize<IEnumerable<UserStory>>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return userStories;
    }
}