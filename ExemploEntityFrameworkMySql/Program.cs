using ExemploEntityFrameworkMySql.Infra.Contexts;
using ExemploEntityFrameworkMySql.Application.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddClientDIServices();
builder.Services.AddClientDIRepositories();

builder.Services.AddDbContext<ExemploEntityFrameworkMySqlContext>();

var app = builder.Build();

app.UseSwaggerUI();
app.UseSwagger();

app.MapControllers();

app.Run();