using Application.LogicInterfaces;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ArtistController : ControllerBase
{
    private readonly IArtistLogic _artistLogic;

    public ArtistController(IArtistLogic artistLogic)
    {
        _artistLogic = artistLogic;
    }
    
    [HttpPost]
    public async Task<ActionResult> CreateAsync(UserCreationDTO dto)
    {
        try
        {
            await _artistLogic.CreateAsync(dto);
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}