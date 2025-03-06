using System;
using Microsoft.Extensions.Logging;
using Soenneker.Tags.Util.Abstract;

namespace Soenneker.Tags.Util;

public class TagsUtil : ITagsUtil
{
    private readonly ILogger<TagsUtil> _logger;

    public TagsUtil(ILogger<TagsUtil> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public TagLib.File? OpenFile(string filePath)
    {
        try
        {
            return TagLib.File.Create(filePath);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while opening the file: {FilePath}", filePath);
        }

        return null;
    }
}