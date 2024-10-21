using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TMS.Data.DTO;
using TMS.Data.Services.Interfaces;

namespace TMS.Api.Controllers
{
    
    [ApiController]
    [Route("api/authentification")]
    public class AuthenticationController : Controller
    {
        private readonly IUserService _userService;

        public AuthenticationController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            try
            {
                var loginResult = await _userService.LoginAsync(loginDTO.Username, loginDTO.Password);
                if(loginResult  == null)
                {
                    return BadRequest(new { Message = "Login Failed" });
                }
                return Ok(new { Token = loginResult.Token,UserId = loginResult.UserId });
                
            }catch(UnauthorizedAccessException Ex)
            {
                return Unauthorized(Ex.Message);    
            }
        }

    }
}
