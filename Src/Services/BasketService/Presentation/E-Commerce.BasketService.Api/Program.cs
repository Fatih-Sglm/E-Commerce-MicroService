using E_Commerce.BasketService.Api.Extensions;
using E_Commerce.BasketService.Application.IntegrationEvents.EventsHandler;
using E_Commerce.BasketService.Infrastructure.Extensions;
using E_Commerce.BasketService.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAuthServices(builder.Configuration);
builder.Services.ConfigureConsul(builder.Configuration);
builder.Services.AddPersistenceRegistraiton();
builder.Services.AddInfratructureRegistration();
builder.Services.AddSingleton(sp => sp.RegisConfiguration(builder.Configuration));
builder.Services.AddSingleton(sp => sp.EventBusRegister());
builder.Services.AddTransient<OrderCreatedIntegrationEventHandler>();
builder.Services.AddHttpContextAccessor();
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
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.EventConfig();
app.Start();
app.RegisterWithConsul(app.Lifetime);
app.WaitForShutdown();
