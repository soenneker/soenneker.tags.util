using Microsoft.Extensions.DependencyInjection;
using Soenneker.Tags.Util.Abstract;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Soenneker.Tags.Util.Registrars;

/// <summary>
/// Represents the tags util registrar.
/// </summary>
public static class TagsUtilRegistrar
{
    /// <summary>
    /// Registers Tags Util with a scoped lifetime.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddTagsUtilAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<ITagsUtil, TagsUtil>();

        return services;
    }
}
