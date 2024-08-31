using Microsoft.AspNetCore.Mvc;
using PruebaTekus.Application.Dtos;
using PruebaTekus.Application.Interfaces;
using PruebaTekus.Application.Services;

namespace PruebaTekus.WebApi.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _iloginService;

        public LoginController(ILoginService iloginService)
        {
            _iloginService = iloginService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserDto userDto)
        {
            var token = await _iloginService.Login(userDto);
            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(new { Token = token });
        }
    }
}
