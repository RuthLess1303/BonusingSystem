using Infrastructure.Services.EmailSender;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ServiceCollectionExtentions
{
    /// <summary>
    /// აქ ამატებთ ყველა სერვისს რომელსაც შექმნით Scope ტიპის სერვისებად
    /// Inrfastructure -ში იქმნება ინფრასტრუქტურული სერვისები, მაგ: S3Adapter, EmailSenderService, Authentification და ა.შ.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IEmailSenderService, EmailSenderService>();

        return services;
    }
}
