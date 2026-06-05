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
    /// Adds tags util as scoped.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddTagsUtilAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<ITagsUtil, TagsUtil>();

        return services;
    }
}