using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Desktop.DTOs
{
    /// <summary>
    /// DTO para representar os dados de login enviados para a API.
    /// Mapeia o JSON enviado no corpo do POST /api/auth/login
    /// </summary>
    public class LoginRequestDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
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

    public class UserResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<string> Roles { get; set; } = new();

        /// <summary>
        /// Verifica se o usuário possui a role "Admin" e retorna true ou false.
        /// usando controle de acesso na interface
        /// </summary>
        public bool IsAdmin => Roles.Contains("Admin");
    }
}
