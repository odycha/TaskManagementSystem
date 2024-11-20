using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TaskManagementSystem.Application.Services.TaskAllocations;
using TaskManagementSystem.Application.Services.TaskTypes;
using TaskManagementSystem.Application.Services.Users;
using TaskManagementSystem.Application.Services.WorkingDays;


namespace TaskManagementSystem.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //Here we also map the services
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<ITaskTypesService, TaskTypesService>();
        services.AddScoped<IWorkingDaysService, WorkingDaysService>();
        services.AddScoped<ITaskAllocationsService, TaskAllocationsService>();
        services.AddScoped<IUserService, UserService>();
		services.AddTransient<IEmailSender, EmailSender>();
        services.AddHttpContextAccessor();
        return services;
    }
}
