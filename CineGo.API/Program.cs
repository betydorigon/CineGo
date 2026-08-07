using CineGo.Domain.Interfaces;
using CineGo.Infrastructure.Repositories; 

var builder = WebApplication.CreateBuilder(args);

// Adicionar Controllers
builder.Services.AddControllers();

// Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Injeção de Dependências (Exemplo: Repositórios da camada Infrastructure)
// builder.Services.AddScoped<IFilmesRepository, FilmesRepository>();
// builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();

var app = builder.Build();

// Configurar o pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();