using Microsoft.EntityFrameworkCore;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Domain.Interfaces.IService;
using ProjetoNotas.Infra.Data.Repository.Context;
using ProjetoNotas.Infra.Data.Repository.Repository;
using ProjetosNotas.Application.Service.SQLServerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(
    options =>
    {
        options.AddPolicy(name: "NoteCors",
            builder =>
            {
                builder.WithOrigins("*");
            });
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Context SQL Server
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnection")));

// ### Dependency Injections
// # Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<INoteRepository, NoteRepository>();

// # Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<INoteService, NoteService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("NoteCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
