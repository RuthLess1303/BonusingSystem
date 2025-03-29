using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceCollectionExtentions
{
    /// <summary>
    /// აქ ამატებთ ყველა სერვისს რომელსაც შექმნით Scope ტიპის სერვისებად
    /// Application ლეიერი გამოიყენება ბიზნეს ლოგიკის იმპლემენტაციისთვის
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ServiceCollectionExtentions));

        return services;
    }
}
