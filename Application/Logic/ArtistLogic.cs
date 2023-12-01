using Application.LogicInterfaces;
using Domain.DTOs;
using Grpc.Net.Client;
using GrpcClient;

namespace Application.Logic;

public class ArtistLogic : IArtistLogic
{
    private readonly ArtistService.ArtistServiceClient _client;

    public ArtistLogic(GrpcService service)
    {
        GrpcChannel channel = service.Channel;
        _client = new ArtistService.ArtistServiceClient(channel);
    }
    
    public async Task CreateAsync(UserCreationDTO dto)
    {
        try
        {
            await _client.createAccountAsync(new CreateArtistRequest
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password,
                ProfilePicture = dto.ProfilePicture
            });
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }    
    }
}