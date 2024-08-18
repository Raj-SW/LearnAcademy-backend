using LearnAcademy.BusinessLayer;
using LearnAcademy.DAL;
using LearnAcademy.Models;
using LearnAcademyBL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LearnAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationBL _authenticationBL;
        public AuthenticationController(IAuthenticationBL authenticationBL)
        {
            _authenticationBL = authenticationBL;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegistrationDTO registrationDTO)
        { 
            var result = await _authenticationBL.Register(registrationDTO);
            
            return Ok(); 
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var result = await _authenticationBL.Login(loginDTO);
            return Ok(result);
        }
    }
}
