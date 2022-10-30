using E_Commerce.IdentityService.Api.Extensions;
using E_Commerce.IdentityService.Infrastructure.Extensions;
using E_Commerce.IdentityService.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.ConfigureConsul(builder.Configuration);
//builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddInfrastructureServices();
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
//app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();



app.Start();
app.RegisterWithConsul(app.Lifetime);

app.WaitForShutdown();