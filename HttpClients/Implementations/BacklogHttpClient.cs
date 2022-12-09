using System.Net.Http.Json;
using System.Text.Json;
using HttpClients.ClientInterfaces;
using Shared.DTOs;
using Shared.Models;

namespace HttpClients.Implementations;

public class BacklogHttpClient : IBackLogService
{
    private readonly HttpClient client;

    public BacklogHttpClient(HttpClient client)
    {
        this.client = client;
    }

    public async Task CreateAsync(BacklogCreationDto dto)
    {
        HttpResponseMessage responseMessage = await client.PostAsJsonAsync("/backlog", dto);
        if (!responseMessage.IsSuccessStatusCode)
        {
            string content = await responseMessage.Content.ReadAsStringAsync();
            throw new Exception(content);
        }
    }

    public async Task<IEnumerable<Backlog>?> GetAsync()
    {
        string uri = "/backlog";
        HttpResponseMessage response = await client.GetAsync(uri);
        string content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(content);
        }

        IEnumerable<Backlog>? backlogs = JsonSerializer.Deserialize<IEnumerable<Backlog>>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return backlogs;
    }
}