using LearnAcademy.BusinessLayer;
using LearnAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
      
        public AuthenticationController()
        {
            
        }

        [HttpPost("register")]
        public IActionResult Register(RegistrationDTO registrationDTO)
        {
            
            return Ok(); 
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDTO loginDTO)
        {

            return Ok();
        }
    }
}
