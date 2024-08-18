using System.ComponentModel.DataAnnotations;

namespace LearnAcademy.Models
{
    public class RegistrationDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public RegistrationDTO(string firstName, string lastName, string email, string pasword) 
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = pasword;
        }

    }
}
