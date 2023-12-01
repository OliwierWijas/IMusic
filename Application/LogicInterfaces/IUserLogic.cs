using Domain.DTOs;

namespace Application.LogicInterfaces;

public interface IUserLogic
{
    Task CreateAsync(UserCreationDTO dto);
}