using LearnAcademy.Models;
using LearnAcademyCommon.Models;

namespace LearnAcademy.BusinessLayer
{
    public interface IAuthenticationBL
    {
        UserDTO Login(string username, string password);
        bool Register(RegistrationDTO registrationDTO);
        bool LogOut();
    }
}
