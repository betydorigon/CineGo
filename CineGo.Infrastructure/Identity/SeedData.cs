using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace CineGo.Infrastructure.Identity
{
    public static class SeedData
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var services = scope.ServiceProvider;

            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();

            // Roles padrão
            var roles = new[] { "Admin", "User" };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            // Cria o usuário Admin se não existir
            var existingAdmin = await userManager.FindByEmailAsync(AdminEmail);
            if (existingAdmin == null)
            {
                var adminUser = new IdentityUser
                {
                    UserName = AdminEmail,
                    Email = AdminEmail,
                    EmailConfirmed = true
                };

                var createResult = await userManager.CreateAsync(adminUser, AdminPassword);
                if (createResult.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
                else
                {
                    // Opcional: trate erros de criação conforme necessidade
                    throw new InvalidOperationException($"Falha ao criar usuário Admin: {string.Join("; ", createResult.Errors)}");
                }
            }
            else
            {
                // Garante que o usuário Admin pertença à role Admin
                if (!await userManager.IsInRoleAsync(existingAdmin, "Admin"))
                {
                    await userManager.AddToRoleAsync(existingAdmin, "Admin");
                }
            }
        }

        // Substitua apenas estas duas linhas abaixo com o email e a senha do Admin
        private const string AdminEmail = "Admin@CineGo.com.br";
        private const string AdminPassword = "Admin@123";
    }
}
