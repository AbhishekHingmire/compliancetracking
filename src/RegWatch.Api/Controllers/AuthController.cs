using Microsoft.AspNetCore.Mvc;
using RegWatch.Core.DTOs;
using RegWatch.Core.Interfaces;
namespace RegWatch.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _users;
    public AuthController(IUserService users) => _users = users;

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto request, CancellationToken ct = default)
    {
        var result = await _users.LoginAsync(request, ct);
        if (!result.Success) return Unauthorized(new { error = result.Error });
        return Ok(result);
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequestDto request, CancellationToken ct = default)
    {
        var result = await _users.RegisterAsync(request, ct);
        if (!result.Success) return BadRequest(new { error = result.Error });
        return Ok(result);
    }
}
