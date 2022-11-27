using E_Commerce.IdentityService.Application.Exceptions;
using E_Commerce.IdentityService.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Reflection;
using TechBuddy.Extension.Validation.Extensions;
using TechBuddy.Extensions.AspNetCore.ExceptionHandling;

namespace E_Commerce.IdentityService.Application.Extensions
{
    public static class ApplicationServices
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(assembly);
            services.AddAutoMapper(assembly);
            services.AddTechBuddyValidator();

        }
        public static void AddWebApplicaitonService(this WebApplication app)
        {
            app.ConfigureTechBuddyExceptionHandling(opt =>
            {

                AddCustomErroHandler<Exception>(opt, HttpStatusCode.InternalServerError, true);
                AddCustomErroHandler<IdentityException>(opt, HttpStatusCode.BadRequest, true);
                AddCustomErroHandler<NotFoundException>(opt, HttpStatusCode.NotFound, true);
            });
        }

        private static void AddCustomErroHandler<T>(ExceptionHandlingOptions opt, HttpStatusCode httpStatusCode, bool isDevelopment) where T : Exception
        {
            opt.AddCustomHandler<T>((context, ex, logger) =>
            {
                ErrorResponseModel model = new()
                {
                    Errors = isDevelopment ? new List<string> { ex.ToString() } : new List<string> { ex.Message }
                };
                context.Response.StatusCode = (int)httpStatusCode;
                return context.Response.WriteAsJsonAsync(model);
            });
        }
    }
}
