using LearnAcademy.Models;
using LearnAcademyCommon.Models;

namespace LearnAcademyBL.Interfaces
{
    public interface IAuthenticationBL
    {
        Task<UserDTO> Login(LoginDTO loginDTO);
        Task<bool> Register(RegistrationDTO registrationDTO);
        bool LogOut();
    }
}
