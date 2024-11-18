using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TaskManagementSystem.Application.Services;
using TaskManagementSystem.Application.Services.TaskTypes;


namespace TaskManagementSystem.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //Here we also map the services
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<ITaskTypesService, TaskTypesService>();
        services.AddTransient<IEmailSender, EmailSender>();
        return services;
    }
}
