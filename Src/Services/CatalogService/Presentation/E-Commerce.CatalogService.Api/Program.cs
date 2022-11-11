using E_Commerce.CatalogService.Api.Extensions;
using E_Commerce.CatalogService.Application.Extensions;
using E_Commerce.CatalogService.Infrastructure.Extensions;
using E_Commerce.CatalogService.Infrastructure.Services.Storage.Local;
using E_Commerce.CatalogService.Persistence.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContextServices(builder.Configuration);
builder.Services.AddStorage<LocalStorage>();
builder.Services.ConfigureConsul(builder.Configuration);
builder.Services.AddPersistenceServiceRegistraiton();
builder.Services.AddApplicationServiceRegistraiton();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Start();
app.RegisterWithConsul(app.Lifetime);
app.WaitForShutdown();