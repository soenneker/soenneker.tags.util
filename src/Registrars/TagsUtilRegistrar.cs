using Microsoft.Extensions.DependencyInjection;
using Soenneker.Tags.Util.Abstract;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Soenneker.Tags.Util.Registrars;

public static class TagsUtilRegistrar
{
    public static IServiceCollection AddTagsUtilAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<ITagsUtil, TagsUtil>();

        return services;
    }
}