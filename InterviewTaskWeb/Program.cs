using InterviewTaskWeb;
using InterviewTaskWeb.DataBase;
using InterviewTaskWeb.DataBase.Interfaces;
using InterviewTaskWeb.ExportImport.Interfaces;
using InterviewTaskWeb.ExportImport.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CompanyContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Регистрация репозиториев и Unit of Work
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Регистрация сервисов
builder.Services.AddScoped<CompanyContext>();
builder.Services.AddScoped<IExportImport, ExportImportService>();

// Регистрация AutoMapper
builder.Services.AddAutoMapper(typeof(CompanyProfile));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();