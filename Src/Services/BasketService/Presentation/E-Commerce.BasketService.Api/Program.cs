using E_Commerce.BasketService.Api.Extensions;
using E_Commerce.BasketService.Application.Extensions;
using E_Commerce.BasketService.Application.IntegrationEvents.EventsHandler;
using E_Commerce.BasketService.Infrastructure.Extensions;
using E_Commerce.BasketService.Persistence.Extensions;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAuthServices(builder.Configuration);
builder.Services.ConfigureConsul(builder.Configuration);
builder.Services.AddPersistenceRegistraiton();
builder.Services.AddInfratructureRegistration();
builder.Services.AddSingleton(sp => sp.RegisConfiguration(builder.Configuration));
builder.Services.AddSingleton(sp => sp.EventBusRegister());
builder.Services.AddApplicationServiceRegistration();
builder.Services.AddTransient<OrderCreatedIntegrationEventEventEventHandler>();
builder.Services.AddHttpContextAccessor();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                        },
                        new List<string>()
                    }
                });
});

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
