using Domain.DTOs;

namespace Application.LogicInterfaces;

public interface IArtistLogic
{
    Task CreateAsync(UserCreationDTO dto);
}