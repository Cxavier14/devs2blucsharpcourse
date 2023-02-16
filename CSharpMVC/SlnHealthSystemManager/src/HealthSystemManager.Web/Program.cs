using HealthSystemManager.Application.Service.SQLServerServices;
using HealthSystemManager.Domain.IRepositories;
using HealthSystemManager.Domain.IServices;
using HealthSystemManager.Infra.Data.Context;
using HealthSystemManager.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context SQL Server
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer("Server=DESKTOP-0OM0TD5\\SQLEXPRESS;Database=HealthSystem;User Id=sa;Password=147258369;TrustServerCertificate=True;"));

// # Dependency Injections #
// # Repositories #
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IMedicalRecordsRepository, MedicalRecordRepository>();

// # Services #
builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IMedicalRecordsService, MedicalRecordService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
