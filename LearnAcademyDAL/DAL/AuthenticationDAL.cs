using LearnAcademy.Models;
using LearnAcademyCommon.Models;
using LearnAcademyDAL.Interfaces;
using System.Data.SqlClient;

namespace LearnAcademy.DAL
{
    public class AuthenticationDAL : IAuthenticationDAL
    {
        private readonly DBCommand _command;
        public AuthenticationDAL() 
        {
            _command = new DBCommand();
        }

        public async Task<bool> RegisterUser(RegistrationDTO registrationDTO)
        {
            string INSERTUSERQUERY = "INSERT INTO [Users] VALUES (@Email, @Password)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Email",registrationDTO.Email));
            parameters.Add(new SqlParameter("@Password",registrationDTO.Password));

            return await _command.InsertUpdateDataAsync(INSERTUSERQUERY, parameters);
        }
        public async Task<UserDTO> Login(LoginDTO loginDTO)
        {
            string QUERYUSER = "SELECT TOP(1) * FROM Users WHERE Email = @Email";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Email", loginDTO.Email));

            var resultList = await _command.GetDataWithConditionsAsync<UserDTO>(QUERYUSER, parameters);

            return resultList.FirstOrDefault();
        } 
    }
}
