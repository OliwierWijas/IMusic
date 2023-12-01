using Domain.DTOs;

namespace HttpClients.ClientImplementations;

public interface IUserService
{
    Task CreateAsync(UserCreationDTO dto);
}