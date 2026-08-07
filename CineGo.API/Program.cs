// =============================================================================
// CineGo.API - Program.cs
// =============================================================================
//  CONCEITO IMPORTANTE: Program.cs
// Este é o PONTO DE ENTRADA da aplicação API.
// Aqui configuramos todos os serviços (DI), middlewares e a pipeline HTTP.
//
// O que é configurado aqui:
// 1. Entity Framework Core (conexão com banco de dados)
// 2. ASP.NET Core Identity (autenticação e autorização)
// 3. Dependency Injection (repositórios e serviços)
// 4. Swagger (documentação da API)
// 5. CORS (permissões de acesso cross-origin)
// =============================================================================

using CineGo.Application.Interfaces;
using CineGo.Application.Services;
using CineGo.Infrastructure.Context;
using CineGo.Infrastructure.Identity;
using CineGo.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// =====================================================================
// 1. ENTITY FRAMEWORK CORE — Configuração do banco de dados
// =====================================================================
//  CONCEITO: AddDbContext registra o DbContext no container de DI.
// UseSqlServer configura o Entity Framework para usar o SQL Server.
// A connection string é lida do arquivo appsettings.json.
// =====================================================================
builder.Services.AddDbContext<CineGoDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConection")));

// =====================================================================
// 2. ASP.NET CORE IDENTITY — Autenticação e Autorização
// =====================================================================
//  CONCEITO: Identity é o sistema de autenticação do ASP.NET Core.
// Ele gerencia: usuários, senhas, roles, claims, login, logout, etc.
// AddIdentity registra os serviços do Identity no container de DI.
// AddEntityFrameworkStores conecta o Identity ao banco via EF Core.
// =====================================================================
builder.Services.AddIdentity<IdentityUser, IdentityRole>(OptionsBuilderConfigurationExtensions =>
{
    // Configurações de senha (simplificadas para ensino)
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;
}) 
.AddEntityFrameworkStores<CineGoDbContext>();
.AddDefaultTokenProviders(); // Necessário para reset de senha, email confirmation, etc.