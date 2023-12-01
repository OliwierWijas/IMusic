using System.Net.Http.Json;
using Domain.DTOs;

namespace HttpClients.ClientImplementations;

public class UserHttpClient : IUserService
{    
    private readonly HttpClient _client;
    
    public UserHttpClient(HttpClient client)
    {
        _client = client;
    }
    
    public async Task CreateAsync(UserCreationDTO dto)
    {
        HttpResponseMessage message = await _client.PostAsJsonAsync("/Users", dto);
        if (!message.IsSuccessStatusCode)
        {
            string content = await message.Content.ReadAsStringAsync();
            throw new Exception(content);
        }    
    }
}