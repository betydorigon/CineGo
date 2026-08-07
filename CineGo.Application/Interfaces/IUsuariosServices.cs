using CineGo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineGo.Application.Interfaces
{
    public interface IUsuariosServices
    {
        Task<IEnumerable<UsuarioDto>> GetAllAsync();
        Task<UsuarioDto?> GetByIdAsync(string id);
        Task<(bool Success, UsuarioDto? usuario, string ErrorMessage)> CreateAsync(CreateUsuarioDto dto);
        Task<(bool Success, UsuarioDto? Usuario, string ErrorMessage)> UpdateAsync(string id, UpdateUsuarioDto dto);
        Task<(bool Success, string ErrorMessage)> DeleteAsync(string id);
        Task<IEnumerable<string>> GetPerfisAsync();
    }
}
