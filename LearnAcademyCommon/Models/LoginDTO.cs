﻿namespace LearnAcademy.Models
{
    public class LoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public LoginDTO(string email, string password) 
        {
            Email = email;  
            Password = password;
        }
    }
}
