using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAcademyCommon.Models
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        //public UserDTO(string email, string userName, string firstName, string lastName, string role)
        //{
        //    Email = email;
        //    UserName = userName;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Role = role;
        //}
    }
}
