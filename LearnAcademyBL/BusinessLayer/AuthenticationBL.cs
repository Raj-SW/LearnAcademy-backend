using LearnAcademy.DAL;
using LearnAcademy.Models;
using LearnAcademyBL.Interfaces;
using LearnAcademyCommon.Models;
using LearnAcademyDAL.Interfaces;

namespace LearnAcademy.BusinessLayer
{
    public class AuthenticationBL : IAuthenticationBL
    {
        private readonly IAuthenticationDAL _authenticationDAL;
        public AuthenticationBL(IAuthenticationDAL authenticationDAL) 
        {
            _authenticationDAL = authenticationDAL;
        }

        public async Task<bool> Register(RegistrationDTO registrationDTO)
        {
            return await _authenticationDAL.RegisterUser(registrationDTO);
        }

        public async Task<UserDTO> Login(LoginDTO loginDTO)
        {
            return await _authenticationDAL.Login(loginDTO);
        }

        public bool LogOut()
        {
            throw new NotImplementedException();
        }

    }
}
