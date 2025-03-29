using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence;

public static class ServiceCollectionExtentions
{
    /// <summary>
    /// აქ ამატებთ ყველა რეპოზიტორის რომელსაც შექმნით Scope ტიპის სერვისებად
    /// ასევე შეგიძლიათ რაიმე ტიპის კონფიგურაცია თუ გინდათ დაამატოთ
    /// Persistence -ში ქმნით ბაზათან კომუნიკაციის სერვისები, მაგ: BonusingSystemRepository, UserRepositroy და ა.შ.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddScoped<IBonusingSystemRepository, BonusingSystemRepository>();

        return services;
    }
}
