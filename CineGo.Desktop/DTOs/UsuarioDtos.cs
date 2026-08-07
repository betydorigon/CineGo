using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Desktop.DTOs
{
    public class UsuarioResponseDtos
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;

    }

    public class CreateUsuarioDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;
    }

    public class UpdateUsuarioDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Perfil { get; set; } = string.Empty;
    }
}
