using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Desktop.DTOs
{
    public class AuthDtos
    {
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }

    public class RegisterRequestDto
    {
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
    public class UserRequestDto 
    {
        public string Email { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public List<string> Roles { get; set; } = new();
        public bool IsAdmin => Roles.Contains("Admin");
    }
}
