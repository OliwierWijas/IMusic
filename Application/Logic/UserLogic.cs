using Application.LogicInterfaces;
using Domain.DTOs;
using Grpc.Net.Client;
using GrpcClient;

namespace Application.Logic;

public class UserLogic : IUserLogic
{
    private readonly UserService.UserServiceClient _client;

    public UserLogic(GrpcService service)
    {
        GrpcChannel channel = service.Channel;
        _client = new UserService.UserServiceClient(channel);
    }
    
    public async Task CreateAsync(UserCreationDTO dto)
    {
        try
        {
            await _client.createAccountAsync(new CreateUserRequest
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