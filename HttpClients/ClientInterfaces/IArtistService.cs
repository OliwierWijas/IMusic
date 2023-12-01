using Domain.DTOs;

namespace HttpClients.ClientImplementations;

public interface IArtistService
{
    Task CreateAsync(UserCreationDTO dto);
}