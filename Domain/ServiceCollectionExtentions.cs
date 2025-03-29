using Microsoft.Extensions.DependencyInjection;

namespace Domain;

public static class ServiceCollectionExtentions
{
    /// <summary>
    /// როგორც წესი აქ არაფრის ჩამატება არ დაგჭირდებათ.
    /// Domain -ში იქმნება მხოლოდ მოდელები, Enum -ები ConsTitles და Options
    /// Options არის მაგალითად JWT-სთვის განკუთვნილი მოდელი რომელსაც JwtOptions ეწოდება
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        return services;
    }
}
