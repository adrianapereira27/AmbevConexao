using AmbevConexao.API.Filtros;
using AmbevConexao.API.Mid;
using AmbevConexao.Data;
using AmbevConexao.Data.Repository;
using AmbevConexao.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomAuthorizationFilter>();
    options.Filters.Add<CustomExceptionFilter>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();

var connectionString = builder.Configuration.GetConnectionString("MinhaConexao"); // MinhaConexao está declarado no appsettings.json
builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

app.UseMiddleware<CustomMiddleware>();  // chamada de um middleware customizado criado em uma classe na API
app.UseMiddleware<ValidateMiddleware>();  // chamada de um middleware customizado criado em uma classe na API

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// criação de um middleware
/*app.Use(async (context, next) =>
{
    Console.WriteLine(context.Request.Path + " Entrando no mid1");

    await next.Invoke();

    Console.WriteLine(context.Request.Path + " Saindo do mid1");
});*/

// criação de um middleware para verificar se existe a chave ambev, caso não exista não permite continuar
/*app.Use(async (context, next) =>
{
    string chave = "ambev";

    if (!context.Request.Headers.ContainsKey(chave))
    {
        return;
    }
    
    await next.Invoke();

});*/

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
