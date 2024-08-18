using LearnAcademy.Models;
using LearnAcademyCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAcademyDAL.Interfaces
{
    public interface IAuthenticationDAL
    {
        Task<bool> RegisterUser(RegistrationDTO registrationDTO);
        Task<UserDTO> Login(LoginDTO loginDTO);
    }
}
